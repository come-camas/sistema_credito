using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Clientes
    {
<<<<<<< HEAD
       
            public int id_cliente { get; set; }
            public string identificacion { get; set; } 
            public string nombre { get; set; }       
            public string direccion { get; set; }
            public string telefono { get; set; }
            public string estado { get; set; }
            public int? creado_por { get; set; }     
            public DateTime fecha_registro { get; set; }
        
=======
        public int id_cliente { get; set; }
        public string identificacion { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string estado { get; set; }
        public Usuarios creado_por { get; set; }
        public DateTime Fecha_registro { get; set; }
>>>>>>> e4f580f763bde06486d9053fc86e2e55ba453006
    }
}
