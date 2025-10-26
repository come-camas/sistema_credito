using Capa_entidad;
using Capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_presentacion
{
    public partial class Registar_clientes : Form
    {
        private readonly int _idUsuarioActual;
        public Registar_clientes(int idUsuarioActual)
        {
            InitializeComponent();
            _idUsuarioActual = idUsuarioActual;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrarcliente_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new Clientes
                {
                    identificacion = string.IsNullOrWhiteSpace(txtcedula.Text) ? null : txtcedula.Text.Trim(),
                    nombre = txtnombre.Text.Trim(),
                    direccion = string.IsNullOrWhiteSpace(txtdireccion.Text) ? null : txtdireccion.Text.Trim(),
                    telefono = string.IsNullOrWhiteSpace(txttelefono.Text) ? null : txttelefono.Text.Trim(),
                    creado_por = _idUsuarioActual
                };

                new CN_Cliente().InsertarCliente(cliente);

                MessageBox.Show("Cliente registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (ApplicationException ex) // errores de validación negocio o duplicado
            {
                MessageBox.Show(ex.Message, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) // errores inesperados
            {
                MessageBox.Show("Ocurrió un error al registrar el cliente: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtcedula.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtnombre.Focus();
        }
    }
}
    

