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
        private readonly int _idUsuario;
        private readonly string _nombreUsuario;

        public int UsuarioId => _idUsuario;
        public string UsuarioNombre => _nombreUsuario;
        private int borderSize = 2;
        public Inicio(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            _nombreUsuario = nombreUsuario;
            verUsuario.Text = $"Usuario: {_nombreUsuario} " ;

            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(0, 120, 215);
        }


      
        public void abrirform(Form formulario)
        {

            if (this.principal.Controls.Count > 0)
                this.principal.Controls.Clear(); 

            
            formulario.TopLevel = false;  
            formulario.FormBorderStyle = FormBorderStyle.None; 
            formulario.Dock = DockStyle.Fill; 

           
            this.principal.Controls.Add(formulario);

            // Mostrar el formulario hijo
            formulario.Show();

        }

        /*
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

                if (menu.Width >= 230)
                {
                    siderbar = true;
                    sliderbar.Stop();

                }



            }
        }
        */

        private void barra_Click(object sender, EventArgs e)
        {
            sliderbar.Start();
        }

        private void submenu_venta_registrar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           

        }

        private void panelc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void btrees_Click(object sender, EventArgs e)
        {

        }

        private void principal_Click(object sender, EventArgs e)
        {

        }

        private void btcuotas_Click(object sender, EventArgs e)
        {

        }

        private void btcliente_Click(object sender, EventArgs e)
        {
            abrirform(new Registar_clientes(this.UsuarioId));
        }

        private void btcreditos_Click(object sender, EventArgs e)
        {
            abrirform(new Registrar_creditos(this.UsuarioId));  

        }

        private void verUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btpagos_Click(object sender, EventArgs e)
        {

        }

        private void btcuotas_Click_1(object sender, EventArgs e)
        {
            abrirform(new ver_cuotas(this.UsuarioId));
        }
    }
}
