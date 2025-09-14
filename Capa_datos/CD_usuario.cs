using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa_entidad;
using System.Data;

namespace Capa_datos
{
   public class CD_usuario
   {
        public List<Usuarios> listar() {

            List<Usuarios> lista = new List<Usuarios>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) {

				try
				{
					string query = "select id_usuario,nombre,hash_password,fecha_registro from usuarios";

					SqlCommand cmd = new SqlCommand(query, oconexion);
					//cmd.CommandText = CommandType.Text;
					oconexion.Open();

					using (SqlDataReader dr = cmd.ExecuteReader()) {

						while (dr.Read()) {
							lista.Add(new Usuarios()
							{

								id_usuario = Convert.ToInt32(dr["id_usuario"]),
								nombre = Convert.ToString(dr["nombre"]),
								hash_password = Convert.ToString(dr["hash_password"]),
								fecha_registro = Convert.ToDateTime(dr["fecha_registro"])

							});		
							
						}
					
					}
				}
				catch (Exception ex)
				{
					lista = new List<Usuarios>();
					throw;
				}

				return lista;
            
            }
        }
   }
}
