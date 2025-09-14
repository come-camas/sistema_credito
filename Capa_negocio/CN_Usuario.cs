using Capa_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_datos;
using Capa_entidad;

namespace Capa_negocio
{
    public class CN_Usuario
    {
        private CD_usuario objusuario = new CD_usuario();

        public List<Usuarios> listar() {

            return objusuario.listar();
        }
    }
}
