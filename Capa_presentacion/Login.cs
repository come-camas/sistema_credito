using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_negocio;
using Capa_entidad;

namespace Capa_presentacion
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void show_password_Click(object sender, EventArgs e)
        {
            if (textBox_contraseña_login.UseSystemPasswordChar == true)
            {
                this.textBox_contraseña_login.UseSystemPasswordChar = false;
            }
            else if (textBox_contraseña_login.UseSystemPasswordChar == false)
            {

                this.textBox_contraseña_login.UseSystemPasswordChar = true;

            }
        }

        private void salir_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox_contraseña_login.Clear();
            textBox_usuario_login.Clear();
        }

        private void login_buttom_Click(object sender, EventArgs e)
        {

            Usuarios objusuario = new CN_Usuario().listar().Where(p => p.nombre == textBox_usuario_login.Text && p.hash_password == textBox_contraseña_login.Text).FirstOrDefault();

            if (objusuario != null)  {

                Inicio ini = new Inicio();
                ini.Show();
                this.Hide();

                ini.FormClosing += form_close;

            }
            else
            {
                MessageBox.Show("No se ha encontrado el usuario","MENSAJE",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
             
            }




        }

        private void form_close(object sender, FormClosingEventArgs e) {
            textBox_contraseña_login.Clear();
            textBox_usuario_login.Clear();
            this.Show();
        }
    }
}
