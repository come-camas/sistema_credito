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
using System.Security.Cryptography;


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
            string usuario = textBox_usuario_login.Text.Trim();
            string pass = textBox_contraseña_login.Text;


            string hashIngresado = Sha256Hex(pass);

        
            Usuarios objusuario = new CN_Usuario()
                .listar()
                .Where(p => p.nombre == usuario &&
                            string.Equals(p.hash_password, hashIngresado, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault();

            if (objusuario != null)
            { 
                Inicio ini = new Inicio(objusuario.id_usuario, objusuario.nombre);
                ini.Show();
                this.Hide();
                ini.FormClosing += form_close;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "MENSAJE",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }




        private static string Sha256Hex(string texto)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(texto);
            using (var sha = SHA256.Create())
            {
                var hash = sha.ComputeHash(bytes);
                var sb = new StringBuilder(hash.Length * 2);
                foreach (var b in hash) sb.Append(b.ToString("X2"));
                return sb.ToString();
            }
        }


        private void form_close(object sender, FormClosingEventArgs e) {
            textBox_contraseña_login.Clear();
            textBox_usuario_login.Clear();
            this.Show();
        }
    }
}
