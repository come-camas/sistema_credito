using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Capa_entidad;
using Capa_negocio;

namespace Capa_presentacion
{
    public partial class Inicio: Form
    {
        bool siderbar = true;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        private static Usuarios usuarioactual;

        public Inicio(Usuarios usuario_usar = null)
        {
            InitializeComponent();
        }

        private void abrirform(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.Ivory;

            }

            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {

                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            

            contenedor.Controls.Add(formulario);
            formulario.Show();

        }

        private void sliderbar_Tick_1(object sender, EventArgs e)
        {
            if (siderbar == true)
            {
                menu.Width -= 10;

                if (menu.Width <= 0)
                {
                    siderbar = false;
                    sliderbar.Stop();

                }
            }
            else
            {

                menu.Width += 10;

                if (menu.Width >= 170)
                {
                    siderbar = true;
                    sliderbar.Stop();

                }



            }
        }

        private void barra_Click(object sender, EventArgs e)
        {
            sliderbar.Start();
        }
    }
}
