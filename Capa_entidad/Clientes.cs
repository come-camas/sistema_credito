using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Clientes
    {
        public int id_cliente { get; set; }
        public string identificacion { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public bool bloqueo { get; set; }
        public decimal MyProperty { get; set; }
        public int fecha_pago_pactada { get; set; }
        public Usuarios creado_por { get; set; }
        public DateTime Fecha_registro { get; set; }
    }
}
