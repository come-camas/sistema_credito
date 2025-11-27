using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Cuotas
    {
        public int id_credito { get; set; }
        public int NroCuota { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal TotalCuota { get; set; }  
        public decimal PagadoCapital { get; set; }
        public decimal PagadoInteres { get; set; }
        public decimal SaldoPendiente { get; set; }
        public string estado { get; set; }
    }
}
