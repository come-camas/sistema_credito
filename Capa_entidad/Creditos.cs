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

       
        public int id_cliente { get; set; }

        
        public DateTime fecha_otorgado { get; set; }

       
        public decimal monto_principal { get; set; }

       
        public decimal tasa_interes_mensual { get; set; }

       
        public string modalidad_pago { get; set; }

        
        public string frecuencia_pago { get; set; }

       
        public int? plazo_total { get; set; }

       
        public string observaciones { get; set; }

       
        public int? creado_por { get; set; }

       
        public DateTime inicio_credito { get; set; }

      
       
    }


}
