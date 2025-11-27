using Capa_datos;
using Capa_entidad;
using Capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa_presentacion
{
    public partial class Registrar_creditos : Form
    {
        private readonly int _idUsuarioActual;
        private GroupBox gB1;
        public Registrar_creditos(int idUsuarioActual)
        {
            InitializeComponent();
            _idUsuarioActual = idUsuarioActual;
            gB1 = this.gb1;
        }

        public void OcultarGroupBox()
        {
            // Hacer invisible el GroupBox
            if (gB1 != null)
            {
                gB1.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        { 
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmodalidad.SelectedItem.ToString() == "PAGO UNICO")
            {

           

                cbfrecuencia.Visible = false;
                label1.Visible = false;

          
               
                txtplazos.Visible = false;
                label2.Visible = false;

                txtplazos.Text = "1";

       
            }
            else if (cbmodalidad.SelectedItem.ToString() == "CUOTAS")
            {
                
                cbfrecuencia.Visible = true;
                label1.Visible = true;

              


            

                txtplazos.Visible = true;
                label2.Visible = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // ------------------ 1. VALIDACIÓN Y RECOLECCIÓN DE DATOS ------------------

                if (Clientes.IdClienteGlobal == 0)
                {
                    MessageBox.Show("No se ha agregado un cliente. Por favor, registre un cliente primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtmontop.Text, out decimal montoPrincipal) || montoPrincipal <= 0)
                {
                    MessageBox.Show("El monto principal tiene un formato incorrecto o es menor o igual a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtinteres.Text, out decimal tasaInteresAnual) || tasaInteresAnual <= 0)
                {
                    MessageBox.Show("La tasa de interés tiene un formato incorrecto o es menor o igual a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtplazos.Text, out int plazoTotal) || plazoTotal <= 0)
                {
                    MessageBox.Show("El plazo total tiene un formato incorrecto o es menor o igual a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string modalidadPago = cbmodalidad.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(modalidadPago))
                {
                    MessageBox.Show("Debe seleccionar la modalidad de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string frecuenciaPago = null;
                string frecuenciaParaCalculo = "MENSUAL"; // Default seguro para cálculo

                if (modalidadPago.ToUpper() == "CUOTAS")
                {
                    frecuenciaPago = cbfrecuencia.SelectedItem?.ToString();
                    if (string.IsNullOrWhiteSpace(frecuenciaPago))
                    {
                        MessageBox.Show("Debe seleccionar la frecuencia de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    frecuenciaParaCalculo = frecuenciaPago; // Usar la frecuencia seleccionada para el cálculo
                }

                // Crear el objeto de crédito
                var credito = new Creditos
                {
                    id_cliente = Clientes.IdClienteGlobal,
                    monto_principal = montoPrincipal,
                    tasa_interes_mensual = tasaInteresAnual,
                    modalidad_pago = modalidadPago,
                    frecuencia_pago = frecuenciaPago, // Esto será NULL si es PAGO UNICO
                    plazo_total = plazoTotal,
                    observaciones = txtobserva.Text,
                    creado_por = _idUsuarioActual,
                    inicio_credito = datetimeinicio.Value
                };

                // ------------------ 2. CALCULAR CUOTAS ------------------

                // Calcular cuotas usando la frecuencia segura
                List<Cuotas> cuotasList = new CN_Credito().CalcularCuotas(
                    montoPrincipal,
                    tasaInteresAnual,
                    plazoTotal,
                    datetimeinicio.Value,
                    credito.modalidad_pago,
                    frecuenciaParaCalculo
                );


                // ------------------ 3. CONFIRMACIÓN Y GUARDADO ------------------

                if (cuotasList.Count > 0)
                {
                    // LÓGICA REINCORPORADA PARA MOSTRAR DETALLES DE CUOTAS
                    string cuotasDetails = "Detalles de las cuotas generadas:\n";
                    foreach (var cuota in cuotasList)
                    {
                        cuotasDetails += $"Cuota {cuota.NroCuota}: Fecha: {cuota.FechaVencimiento.ToShortDateString()}, Capital: {cuota.Capital:C}, Interés: {cuota.Interes:C}, Total Cuota: {cuota.TotalCuota:C}\n";
                    }
                    // FIN DE LA LÓGICA DE MOSTRAR CUOTAS

                    var result = MessageBox.Show(cuotasDetails + "\n¿Desea guardar el crédito y las cuotas?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        // PASO CRÍTICO 1: Insertar el crédito y obtener el ID generado
                        CN_Credito negocioCredito = new CN_Credito();

                        // NOTA: Se asume que InsertarCredito ya fue modificado para devolver INT
                        int nuevoIdCredito = negocioCredito.InsertarCredito(credito);

                        if (nuevoIdCredito > 0)
                        {
                            // PASO CRÍTICO 2: Asignar el nuevo ID a CADA cuota
                            procedimientos_creditos _datos = new procedimientos_creditos();
                            foreach (var cuota in cuotasList)
                            {
                                cuota.id_credito = nuevoIdCredito; // **ASIGNACIÓN DEL ID DE CRÉDITO**
                                _datos.InsertarCuota(cuota);
                            }

                            MessageBox.Show("Crédito y cuotas registrados correctamente.");
                            LimpiarCampos();
                            Clientes.IdClienteGlobal = 0;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("El crédito no se pudo guardar. No se obtuvo un ID de crédito válido.", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Operación cancelada. No se guardaron los datos.");
                        LimpiarCampos();
                        Clientes.IdClienteGlobal = 0;
                    }
                }
                else
                {
                    MessageBox.Show("El cálculo de cuotas no pudo generar ningún registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el crédito: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
           
            txtmontop.Clear();
            txtinteres.Clear();
            txtplazos.Clear();
            txtobserva.Clear();
          

            datetimeinicio.Value = DateTime.Now; 
            txtcedula3.Clear();
           
        }


        private void Registrar_creditos_Load(object sender, EventArgs e)
        {
       

            datetimeinicio.Format = DateTimePickerFormat.Custom;
            datetimeinicio.CustomFormat = "dd/MM/yyyy"; 
            datetimeinicio.Value = DateTime.Now;
            datetimeinicio.MinDate = DateTime.Now;


        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = txtcedula3.Text.Trim();

                if (string.IsNullOrEmpty(cedula))
                {
                    MessageBox.Show("Por favor ingrese una cédula.");
                    return;
                }

               
                CN_Cliente negocioCliente = new CN_Cliente();
                int idCliente = negocioCliente.BuscarIdClientePorCedula(cedula);

                if (idCliente > 0)
                {
                   
                    MessageBox.Show($"Credito Aceptado");

                    Clientes.IdClienteGlobal = idCliente;
                }
                else
                {
                    MessageBox.Show("No se encontraron clientes con esa cédula.");
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se le puede aceptar el credito al cliente " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datetimeu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datetimes_ValueChanged(object sender, EventArgs e)
        {

           
        }
        

        private void modificar_Click(object sender, EventArgs e)
        {
            generarcuotas.Visible = false;  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
