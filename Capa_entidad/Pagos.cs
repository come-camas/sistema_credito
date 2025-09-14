using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Pagos
    {
        public int id_pago { get; set; }
        public Creditos id_credito { get; set; }
        public DateTime fecha_pago { get; set; }
        public decimal monto_total { get; set; }
        public string medio_pago { get; set; }
        public string moneda { get; set; }
        public string referencia  { get; set; }
        public Usuarios recibido_por { get; set; }
        public string observaciones { get; set; }
    }
}
