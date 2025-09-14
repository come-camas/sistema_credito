using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Detalle_Pago
    {
        public int id_detalle_pago { get; set; }
        public Pagos id_pago { get; set; }
        public string tipo_pago { get; set; }
        public Cuotas id_cuota { get; set; }
        public decimal detalle_interes { get; set; }
        public decimal detalle_capital { get; set; }
    }
}
