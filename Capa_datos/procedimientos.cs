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
        public void InsertarCliente(Clientes c)
        {
            using (var con = new SqlConnection(Conexion.cadena))
            using (var cmd = new SqlCommand("dbo.sp_insertar_cliente", con))
            {
                cmd.CommandType = CommandType.StoredProcedure; // ← IMPORTANTE

                cmd.Parameters.Add("@identificacion", SqlDbType.VarChar, 40)
                    .Value = (object)c.identificacion ?? DBNull.Value;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 160)
                    .Value = c.nombre; // requerido (valídalo antes)
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 255)
                    .Value = (object)c.direccion ?? DBNull.Value;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 40)
                    .Value = (object)c.telefono ?? DBNull.Value;
                cmd.Parameters.Add("@creado_por", SqlDbType.Int)
                    .Value = (object)c.creado_por ?? DBNull.Value;

                con.Open();
                cmd.ExecuteNonQuery();
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
    }
}
