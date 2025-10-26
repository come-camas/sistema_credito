using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Text.RegularExpressions;
using Capa_entidad;
using Capa_datos;
using System.Data.SqlClient;

namespace Capa_negocio
{
    public class CN_Cliente
    {
        private readonly CD_Cliente _datos = new CD_Cliente();

        public void InsertarCliente(Clientes c)
        {

            if (string.IsNullOrWhiteSpace(c.nombre))
                throw new ApplicationException("El nombre es obligatorio.");

            if (!System.Text.RegularExpressions.Regex.IsMatch(c.nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
                throw new ApplicationException("El nombre solo puede contener letras y espacios.");

            if (string.IsNullOrWhiteSpace(c.identificacion))
                throw new ApplicationException("La cédula es obligatoria.");


           
            if (c.identificacion != null && c.identificacion.Length > 17)
                throw new ApplicationException("La identificación supera los 40 caracteres.");
 
 
            if (!string.IsNullOrWhiteSpace(c.telefono))
            {
            
                if (!Regex.IsMatch(c.telefono, @"^[0-9\+\-\s\(\)]{6,40}$"))
                    throw new ApplicationException("El teléfono contiene caracteres no permitidos.");
            }

            if (!string.IsNullOrWhiteSpace(c.identificacion))
            {

               
                if (_datos.CedulaExiste(c.identificacion))
                    throw new ApplicationException("La identificación ya está registrada.");
            }

           
            if (c.creado_por == null || c.creado_por <= 0)
                throw new ApplicationException("No se pudo determinar el usuario que crea el registro.");

           
            try
            {
                _datos.InsertarCliente(c);
            }
            catch (SqlException ex)
            {
               
                throw new ApplicationException(ex.Message, ex);
            }
        }
    }
}
