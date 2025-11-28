using Capa_entidad;
using Capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_datos;
using ReaLTaiizor.Forms;
using System.Text.RegularExpressions;

namespace Capa_presentacion
{
    public partial class Registar_clientes : Form
    {
        private readonly int _idUsuarioActual;
        private readonly string _nombreUsuario;
        /* private DataGridView dgvClientes;
         private List<int> clienteIds;
        */
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
           
        }

        private void LimpiarFormulario()
        {
            txtcedula.Clear();
            txtnombre.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtnombre.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void validar_telefono (string tel){


             const string patron_celular = @"^(?:\+505|505)?([578]\d{7})$";
        
        }

        private void Registar_clientes_Load(object sender, EventArgs e)
        {

            CargarClientes();

        }
        private void CargarClientes()
        {
            string connectionString = Conexion.cadena;

          
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
              
                string query = "SELECT identificacion, nombre, direccion, telefono FROM clientes";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                   
                    da.Fill(dt);

                   
                    listac.Rows.Clear();

                   
                    foreach (DataRow row in dt.Rows)
                    {
                       
                        listac.Rows.Add(
                            row["identificacion"],  
                            row["nombre"],          
                            row["direccion"],      
                            row["telefono"]         
                        );
                    }
                    listac.DefaultCellStyle.ForeColor = Color.Black; 

                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error al cargar los clientes");
                }
            }
        }
        public void BuscarPorCedula()
        {
    
            string cedula = txtcedula2.Text.Trim();

            if (string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("Por favor ingrese una cédula.");
                return;
            }

            if (!Regex.IsMatch(cedula, @"^\d{3}-\d{6}-\d{4}[A-Z]$"))
            {
                MessageBox.Show("La cedula debe de llevar el siguiente formato para que sea buscado: 000-DDMMAA-0000L", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionString = Conexion.cadena;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    string query = "SELECT identificacion, nombre, direccion, telefono FROM clientes WHERE identificacion = @cedula";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@cedula", cedula);
                    DataTable dt = new DataTable();

                    try
                    {

                        da.Fill(dt);


                        if (dt.Rows.Count > 0)
                        {

                            DataRow row = dt.Rows[0];


                            txtcedula.Text = row["identificacion"].ToString();
                            txtnombre.Text = row["nombre"].ToString();
                            txtdireccion.Text = row["direccion"].ToString();
                            txttelefono.Text = row["telefono"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron clientes con esa cédula.");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al buscar el cliente: " + ex.Message);
                    }
                }

            }
        }



        private void button2_Click(object sender, EventArgs e)
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

              
                int clienteId = new CN_Cliente().InsertarCliente(cliente);

                Clientes.IdClienteGlobal = clienteId;

                MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();  
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void listac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listac_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = listac.Rows[e.RowIndex];

            txtcedula2.Text = fila.Cells["identificacion"].Value?.ToString();
            txtcedula.Text = fila.Cells["identificacion"].Value?.ToString();
            txtnombre.Text = fila.Cells["nombre"].Value?.ToString();
            txtdireccion.Text = fila.Cells["direccion"].Value?.ToString();
            txttelefono.Text = fila.Cells["telefono"].Value?.ToString();

            guardar.Visible = false;
            modificar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarPorCedula();
            if (!string.IsNullOrEmpty(txtcedula.Text))
            {
                guardar.Visible = false;    
                modificar.Visible = true;  
            }
            else
            {
                
                guardar.Visible = true;
                modificar.Visible = false;
            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
           
                string connectionString = Conexion.cadena;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("sp_ModificarCliente", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                       
                        cmd.Parameters.AddWithValue("@IdentificacionOriginal", txtcedula2.Text.Trim());

                       
                        if (string.IsNullOrWhiteSpace(txtcedula.Text))
                            cmd.Parameters.AddWithValue("@IdentificacionNueva", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@IdentificacionNueva", txtcedula.Text.Trim());

                       
                        if (string.IsNullOrWhiteSpace(txtnombre.Text))
                            cmd.Parameters.AddWithValue("@Nombre", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Nombre", txtnombre.Text.Trim());

                      
                        if (string.IsNullOrWhiteSpace(txtdireccion.Text))
                            cmd.Parameters.AddWithValue("@Direccion", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Direccion", txtdireccion.Text.Trim());

                       
                        if (string.IsNullOrWhiteSpace(txttelefono.Text))
                            cmd.Parameters.AddWithValue("@Telefono", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Telefono", txttelefono.Text.Trim());

                       
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cliente modificado correctamente.");

                        
                        guardar.Visible = true;
                        modificar.Visible = false;
                    txtcedula2.Clear();
                    txtcedula.Clear();
                    txtnombre.Clear();
                    txtdireccion.Clear();
                    txttelefono.Clear();
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar el cliente: " + ex.Message);
                    }
                }
            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Clientes.IdClienteGlobal == 0)
            {
                
                MessageBox.Show("No se ha agregado un cliente. Por favor, registre un cliente primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

           
            Registrar_creditos registrarCredito = new Registrar_creditos(_idUsuarioActual);
            Inicio inicioForm = (Inicio)Application.OpenForms["Inicio"]; 

            if (inicioForm != null)
            {
               
                inicioForm.abrirform(registrarCredito);

               
                registrarCredito.OcultarGroupBox();
            }
            else
            {
                MessageBox.Show("El formulario Inicio no está abierto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
    }


