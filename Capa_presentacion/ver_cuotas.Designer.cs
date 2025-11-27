namespace Capa_presentacion
{
    partial class ver_cuotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtcalendario = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcedula3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtcalendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtcalendario
            // 
            // 
            // dtcalendario
            // 
            this.dtcalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // --- ESTILO DE CELDAS POR DEFECTO (Filas Normales) ---
            System.Windows.Forms.DataGridViewCellStyle defaultStyle = new System.Windows.Forms.DataGridViewCellStyle();
            defaultStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            defaultStyle.BackColor = System.Drawing.Color.White; // Fondo Blanco para contraste
            defaultStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            defaultStyle.ForeColor = System.Drawing.Color.Black; // Texto Negro
            defaultStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            defaultStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            defaultStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtcalendario.DefaultCellStyle = defaultStyle;

            // --- ESTILO DE FILAS ALTERNAS (Para asegurar que no haya texto blanco) ---
            System.Windows.Forms.DataGridViewCellStyle alternatingStyle = new System.Windows.Forms.DataGridViewCellStyle();
            alternatingStyle.BackColor = System.Drawing.Color.LightGray; // Fondo Gris Claro para filas alternas
            alternatingStyle.ForeColor = System.Drawing.Color.Black;     // Texto Negro
            alternatingStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            alternatingStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtcalendario.AlternatingRowsDefaultCellStyle = alternatingStyle;

            // --- PROPIEDADES GENERALES ---
            this.dtcalendario.BackgroundColor = System.Drawing.Color.White; // Fondo general del control blanco
            this.dtcalendario.Location = new System.Drawing.Point(185, 360);
            this.dtcalendario.Name = "dtcalendario";
            this.dtcalendario.RowHeadersWidth = 62;
            this.dtcalendario.RowTemplate.Height = 28;
            this.dtcalendario.Size = new System.Drawing.Size(1897, 1000);
            this.dtcalendario.TabIndex = 0;
            this.dtcalendario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtcalendario_CellContentClick);
            this.dtcalendario.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dtcalendario_RowPrePaint);
            //

            // ...
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(167, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 37);
            this.label12.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Capa_presentacion.Properties.Resources.dinero__3_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(24, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 117);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(157, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Últimas cuotas generadas";
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.Beige;
            this.gb1.Controls.Add(this.btBuscar);
            this.gb1.Controls.Add(this.label6);
            this.gb1.Controls.Add(this.txtcedula3);
            this.gb1.Controls.Add(this.label7);
            this.gb1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gb1.Location = new System.Drawing.Point(1432, 30);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(700, 274);
            this.gb1.TabIndex = 21;
            this.gb1.TabStop = false;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.White;
            this.btBuscar.BackgroundImage = global::Capa_presentacion.Properties.Resources.lupa__2_;
            this.btBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.ForeColor = System.Drawing.Color.Black;
            this.btBuscar.Location = new System.Drawing.Point(576, 122);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(74, 52);
            this.btBuscar.TabIndex = 24;
            this.btBuscar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(426, 37);
            this.label6.TabIndex = 21;
            this.label6.Text = "Buscar calendario de pago";
            // 
            // txtcedula3
            // 
            this.txtcedula3.BackColor = System.Drawing.Color.White;
            this.txtcedula3.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcedula3.ForeColor = System.Drawing.Color.Black;
            this.txtcedula3.Location = new System.Drawing.Point(158, 121);
            this.txtcedula3.Name = "txtcedula3";
            this.txtcedula3.Size = new System.Drawing.Size(376, 40);
            this.txtcedula3.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(27, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 33);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cédula:";
            // 
            // ver_cuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 681);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtcalendario);
            this.Name = "ver_cuotas";
            this.Text = "cuotas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cuotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtcalendario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtcalendario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcedula3;
        private System.Windows.Forms.Label label7;
    }
}