using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_negocio
{
    public class CN_Credito
    {


        private readonly procedimientos_creditos _datos = new procedimientos_creditos();




        public bool ClienteTieneCreditoPendiente(int id_cliente)
        {
            return _datos.ClienteTieneCreditoPendiente(id_cliente);
        }


        public int InsertarCredito(Creditos credito)
        {
            if (string.IsNullOrWhiteSpace(credito.modalidad_pago))
            {
                throw new ApplicationException("La modalidad de pago es obligatoria.");
            }

            if (credito.monto_principal <= 0)
            {
                throw new ApplicationException("El monto principal debe ser mayor que cero.");
            }

            if (ClienteTieneCreditoPendiente(credito.id_cliente))
            {
                throw new ApplicationException("El cliente ya tiene un crédito pendiente.");
            }

            try
            {
                // 1. Modificamos la llamada para que capture el ID generado.
                // Asumimos que _datos.InsertarCredito ha sido modificado para devolver int.
                int nuevoIdCredito = _datos.InsertarCredito(credito);

                // 2. Retornamos el ID.
                return nuevoIdCredito;
            }
            catch (SqlException ex)
            {
                // Si hay un error de SQL, lanzamos una excepción más específica.
                throw new ApplicationException("Ocurrió un error al registrar el crédito: " + ex.Message, ex);
            }
        }

        public List<Cuotas> CalcularCuotas(decimal montoPrincipal, decimal tasaInteresAnual, int plazoTotal, DateTime inicioCredito, string modalidadPago, string frecuenciaPago)
        {
            List<Cuotas> cuotasList = new List<Cuotas>();
            decimal saldoPendiente = montoPrincipal;

            decimal tasaPeriodica = 0;
            int divisor = 0; 

            if (frecuenciaPago == "MENSUAL")
            {
                divisor = 12;
            }
            else if (frecuenciaPago == "SEMANAL")
            {
                divisor = 52;
            }
            else if (frecuenciaPago == "QUINCENAL")
            {
                divisor = 24; 
            }
            else
            {
                throw new ApplicationException("Frecuencia de pago no válida.");
            }

            tasaPeriodica = tasaInteresAnual / 100 / divisor; 

            if (tasaPeriodica < 0) tasaPeriodica = 0;
            if (modalidadPago == "PAGO UNICO")
            {
                decimal interesTotal = montoPrincipal * tasaPeriodica * plazoTotal; // Interés simple
                decimal totalAPagar = montoPrincipal + interesTotal;
                DateTime fechaVencimiento = inicioCredito;

                cuotasList.Add(new Cuotas
                {
                    NroCuota = 1,
                   
                    FechaVencimiento = fechaVencimiento,
                    Capital = montoPrincipal,
                    Interes = interesTotal,
                    TotalCuota = totalAPagar,
                    SaldoPendiente = 0,
                    estado = "PENDIENTE"
                });
            }
           
            else if (modalidadPago == "CUOTAS")
            {
                decimal cuotaFija = 0;

                if (tasaPeriodica == 0)
                {
                  
                    cuotaFija = montoPrincipal / plazoTotal;
                }
                else
                {
                   
                    decimal numerador = montoPrincipal * tasaPeriodica;
                   
                    double denominador = 1 - Math.Pow((double)(1 + tasaPeriodica), -plazoTotal);

                
                    cuotaFija = (decimal)(numerador / (decimal)denominador);
                }

              
                for (int i = 1; i <= plazoTotal; i++)
                {
                    decimal interes = saldoPendiente * tasaPeriodica; 
                    decimal capital = cuotaFija - interes;
                    decimal totalCuota = capital + interes;

                  
                    if (i == plazoTotal)
                    {
                        capital = saldoPendiente; 
                        interes = cuotaFija - capital; 
                        if (interes < 0) interes = 0; 
                        totalCuota = capital + interes;
                        saldoPendiente = 0;
                    }
                    else
                    {
                        saldoPendiente -= capital;
                    }


                    DateTime fechaVencimiento = CalcularFechaVencimiento(inicioCredito, frecuenciaPago, i);

                
                    cuotasList.Add(new Cuotas
                    {
                        NroCuota = i,
                        FechaVencimiento = fechaVencimiento,
                        Capital = capital,
                        Interes = interes,
                        TotalCuota = totalCuota,
                        SaldoPendiente = saldoPendiente,
                        estado = "PENDIENTE"
                    });
                }
            }

            return cuotasList;
        }

    

        private DateTime CalcularFechaVencimiento(DateTime fechaInicio, string frecuencia, int numeroCuota)
        {
            DateTime fechaVencimiento = fechaInicio;

            switch (frecuencia.ToUpper())
            {
                case "SEMANAL":
                   
                    fechaVencimiento = fechaInicio.AddDays(7 * numeroCuota);
                    break;

                case "QUINCENAL":
                   
                    DateTime primerVencimiento;

                    if (fechaInicio.Day <= 15)
                    {
                        
                        DateTime proximoDia15 = new DateTime(fechaInicio.Year, fechaInicio.Month, 15);

                      
                        DateTime finDelMes = new DateTime(fechaInicio.Year, fechaInicio.Month, 1).AddMonths(1).AddDays(-1);

                        if (fechaInicio.Day > 15)
                        {
                        
                            primerVencimiento = finDelMes;
                        }
                        else if (fechaInicio.Day <= 15 && fechaInicio.Day > 0)
                        {
                          
                            primerVencimiento = proximoDia15;

                            
                            if (primerVencimiento <= fechaInicio)
                            {
                              
                                primerVencimiento = finDelMes;
                            }
                        }
                        else
                        {
                           
                            primerVencimiento = finDelMes;
                        }

                    }
                    else
                    {
                     
                        DateTime inicioDelMesSiguiente = fechaInicio.AddMonths(1);
                        primerVencimiento = new DateTime(inicioDelMesSiguiente.Year, inicioDelMesSiguiente.Month, 1).AddDays(-1); 
                    }

                 
                    if (fechaInicio.Day <= 15)
                    {
                       
                        primerVencimiento = new DateTime(fechaInicio.Year, fechaInicio.Month, 15);

                     
                        if (primerVencimiento < fechaInicio)
                        {
                            primerVencimiento = new DateTime(fechaInicio.Year, fechaInicio.Month, 1).AddMonths(1).AddDays(-1); 
                        }
                    }
                    else 
                    {
                        
                        primerVencimiento = new DateTime(fechaInicio.Year, fechaInicio.Month, 1).AddMonths(1).AddDays(-1); 

                        if (primerVencimiento < fechaInicio)
                        {
                           
                            primerVencimiento = primerVencimiento.AddMonths(1);
                        }
                    }

         
                    fechaVencimiento = primerVencimiento;

                
                    for (int k = 1; k < numeroCuota; k++)
                    {

                        if (fechaVencimiento.Day == 15)
                        {
                            fechaVencimiento = new DateTime(fechaVencimiento.Year, fechaVencimiento.Month, 1).AddMonths(1).AddDays(-1);
                        }
            
                        else
                        {
                            fechaVencimiento = fechaVencimiento.AddMonths(1);
                            fechaVencimiento = new DateTime(fechaVencimiento.Year, fechaVencimiento.Month, 15);
                        }
                    }
                    break;

                case "MENSUAL":
 
                    fechaVencimiento = fechaInicio.AddMonths(numeroCuota);
                    break;

                default:
                    throw new ApplicationException("Frecuencia de pago no válida.");
            }

            return fechaVencimiento;
        }

    }
}
