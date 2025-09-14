using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Cuotas
    {
        public int id_cuota { get; set; }
        public Creditos id_credito { get; set; }
        public int nro_cuota { get; set; }
        public DateTime fecha_vencimiento{ get; set; }
        public decimal capital { get; set; }
        public decimal interes { get; set; }
        public decimal pagado_capital { get; set; }
        public decimal pagado_interes { get; set; }
        public string estado { get; set; }
    }
}
