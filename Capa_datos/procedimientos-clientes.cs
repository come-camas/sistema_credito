using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_entidad;



namespace Capa_datos
{
    public class CD_Cliente
    {
       
        public int InsertarCliente(Clientes c)
        {
            using (var con = new SqlConnection(Conexion.cadena))
            using (var cmd = new SqlCommand("dbo.sp_insertar_cliente", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@identificacion", SqlDbType.VarChar, 40)
                    .Value = (object)c.identificacion ?? DBNull.Value;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 160)
                    .Value = c.nombre;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 255)
                    .Value = (object)c.direccion ?? DBNull.Value;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 40)
                    .Value = (object)c.telefono ?? DBNull.Value;
                cmd.Parameters.Add("@creado_por", SqlDbType.Int)
                    .Value = (object)c.creado_por ?? DBNull.Value;

                con.Open();
                var result = cmd.ExecuteScalar();
                c.id_cliente = Convert.ToInt32(result);
                return c.id_cliente;
            }
        }

        public bool CedulaExiste(string identificacion)
        {
            if (string.IsNullOrWhiteSpace(identificacion)) return false;

            using (var con = new SqlConnection(Conexion.cadena))
            using (var cmd = new SqlCommand("SELECT 1 FROM dbo.clientes WHERE identificacion = @id", con))
            {
                cmd.Parameters.AddWithValue("@id", identificacion);
                con.Open();
                var r = cmd.ExecuteScalar();
                return r != null;
            }
        }



        public int BuscarIdClientePorCedula(string cedula)
        {
            string connectionString = Conexion.cadena;
            int idCliente = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT id_cliente FROM clientes WHERE identificacion = @cedula";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cedula", cedula);

                try
                {
                    conn.Open();
                    var result = cmd.ExecuteScalar(); 

                    if (result != null)
                    {
                        idCliente = Convert.ToInt32(result);
                    }

                   
                    if (idCliente > 0)
                    {
                      
                        string queryCreditoPendiente = "SELECT COUNT(*) FROM creditos WHERE id_cliente = @idCliente AND estado = 'PENDIENTE'";
                        SqlCommand cmdCredito = new SqlCommand(queryCreditoPendiente, conn);
                        cmdCredito.Parameters.AddWithValue("@idCliente", idCliente);
                        int count = Convert.ToInt32(cmdCredito.ExecuteScalar());

                       
                        if (count > 0)
                        {
                            throw new ApplicationException("El cliente ya tiene un crédito pendiente.");
                        }
                    }
                    else
                    {
                        throw new ApplicationException("No se encontró un cliente con esa cédula.");
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error al buscar el ID del cliente o al verificar el crédito pendiente: " + ex.Message);
                }
            }

            return idCliente;
        }
    }
   
}



