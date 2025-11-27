using Capa_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_presentacion
{
    public partial class ver_cuotas : Form
    {
        private readonly int _idUsuarioActual;
        public ver_cuotas(int idUsuarioActual)
        {
            InitializeComponent();
            _idUsuarioActual = idUsuarioActual;
        }

        private void cuotas_Load(object sender, EventArgs e)
        {
            CargarUltimasCuotas(dtcalendario);


        }

        private void CargarUltimasCuotas(DataGridView dgv)
        {
            string connectionString = Conexion.cadena;

            string query = @"
        WITH UltimoCredito AS (
            -- 1. Obtener el ID del último crédito guardado
            SELECT MAX(id_credito) AS MaxIdCredito
            FROM Creditos
        )
        SELECT
            -- Mostrar datos de cabecera (Nombre, Modalidad, Frecuencia) solo en la primera fila
            CASE 
                WHEN ROW_NUMBER() OVER (ORDER BY CU.nro_cuota ASC) = 1 THEN P.nombre
                ELSE NULL 
            END AS Cliente,
            
            CASE 
                WHEN ROW_NUMBER() OVER (ORDER BY CU.nro_cuota ASC) = 1 THEN CR.modalidad_pago 
                ELSE NULL 
            END AS Modalidad,
            
            CASE 
                WHEN CR.modalidad_pago = 'CUOTAS' AND ROW_NUMBER() OVER (ORDER BY CU.nro_cuota ASC) = 1 THEN CR.frecuencia_pago 
                ELSE NULL 
            END AS Frecuencia,
            
            -- Detalles de la Cuota
            CU.nro_cuota AS Nro_Cuota,
            CU.fecha_vencimiento AS Fecha_Vencimiento,
            CU.capital AS Capital,
            CU.interes AS Interes,
            CU.total_cuota AS Total_Cuota,
            CU.saldo_pendiente AS Saldo_Pendiente,
            CU.estado AS Estado
        FROM
            Creditos CR
        INNER JOIN 
            Clientes P ON CR.id_cliente = P.id_cliente
        INNER JOIN 
            Cuotas CU ON CR.id_credito = CU.id_credito
        WHERE
            CR.id_credito = (SELECT MaxIdCredito FROM UltimoCredito)
        ORDER BY
            CU.nro_cuota ASC;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();


                        da.Fill(dt);

                   
                        if (dt.Rows.Count > 0)
                        {
                            dgv.DataSource = dt;
                            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                      
                            dgv.AutoGenerateColumns = true;
                        }
                        else
                        {
                            dgv.DataSource = null;
                            MessageBox.Show("No se encontraron cuotas para el último crédito.", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar el calendario de cuotas: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dtcalendario_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Obtiene la fila actual
            DataGridViewRow row = dtcalendario.Rows[e.RowIndex];

            // Establece el ForeColor de la fila a NEGRO, forzando la visualización del texto.
            row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;

            // Establece el BackColor para asegurar el contraste: blanco para filas normales
            if (e.RowIndex % 2 == 0) // Filas pares (0, 2, 4...)
            {
                row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            }
            // Gris claro para filas alternas
            else // Filas impares (1, 3, 5...)
            {
                row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            }
        }

        private void dtcalendario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
