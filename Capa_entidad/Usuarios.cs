using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Usuarios
    {
        public int id_usuario { get; set; }
        public string nombre{ get; set; }

        public string hash_password { get; set; }

        public DateTime fecha_registro { get; set; }

    }
}
