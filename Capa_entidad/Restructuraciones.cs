using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Restructuraciones
    {
        public int id_restucturacion { get; set; }
        public Creditos id_credito { get; set; }
        public DateTime fecha_restucturacion { get; set; }
        public string tipo { get; set; }
        public int nuevo_plazo { get; set; }
        public decimal tasa_interes { get; set; }
        public string motivo { get; set; }
        public Usuarios restructurado_por { get; set; }
    }
}
