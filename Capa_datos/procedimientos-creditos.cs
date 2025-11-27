using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_datos
{
    public class procedimientos_creditos
    {
        public bool ClienteTieneCreditoPendiente(int id_cliente)
        {
            string connectionString = Conexion.cadena;

            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM creditos WHERE id_cliente = @id_cliente AND estado = 'PENDIENTE'", con))
                {
                    cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                    con.Open();

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }


        }

        public int InsertarCredito(Creditos credito)
        {
            int nuevoIdCredito = 0;
            string connectionString = Conexion.cadena;

            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("sp_insertar_credito", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                  
                    cmd.Parameters.AddWithValue("@id_cliente", credito.id_cliente);
                    cmd.Parameters.AddWithValue("@monto_principal", credito.monto_principal);
                    cmd.Parameters.AddWithValue("@tasa_interes_mensual", credito.tasa_interes_mensual);
                    cmd.Parameters.AddWithValue("@modalidad_pago", credito.modalidad_pago);

                  
                    cmd.Parameters.AddWithValue("@frecuencia_pago", credito.frecuencia_pago ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@plazo_total", credito.plazo_total);
                    cmd.Parameters.AddWithValue("@estado", "PENDIENTE"); 
                    cmd.Parameters.AddWithValue("@observaciones", credito.observaciones ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@inicio_credito", credito.inicio_credito);
                    cmd.Parameters.AddWithValue("@creado_por", credito.creado_por);

                    con.Open();

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                      
                        nuevoIdCredito = Convert.ToInt32(resultado);
                    }
                }
            }

          
            return nuevoIdCredito;
        }

        public void InsertarCuota(Cuotas cuota)
        {
            string connectionString = Conexion.cadena;

            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("sp_insertar_cuota", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_credito", cuota.id_credito);
                    cmd.Parameters.AddWithValue("@nro_cuota", cuota.NroCuota);
                    cmd.Parameters.AddWithValue("@fecha_vencimiento", cuota.FechaVencimiento);
                    cmd.Parameters.AddWithValue("@capital", cuota.Capital);
                    cmd.Parameters.AddWithValue("@interes", cuota.Interes);
                    cmd.Parameters.AddWithValue("@total_cuota", cuota.TotalCuota); 
                    cmd.Parameters.AddWithValue("@saldo_pendiente", cuota.SaldoPendiente);
                 

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}