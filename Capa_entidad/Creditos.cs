using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Creditos
    {
        public int id_credito { get; set; }
        public Clientes id_cliente { get; set; }
        public DateTime fecha_otorgado { get; set; }
        public decimal monto_principal { get; set; }
        public decimal tasa_interes_mensual { get; set; }
        public string  modalidad_pago { get; set; }
        public string frecuencia_pago { get; set; }
        public int plazo_total { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public string estado { get; set; }
        public string  observaciones { get; set; }
        public Usuarios creado_por { get; set; }

    }
}
