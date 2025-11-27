namespace Capa_presentacion
{
    partial class Registrar_creditos
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
            this.txtobserva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmontop = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbmodalidad = new System.Windows.Forms.ComboBox();
            this.cbfrecuencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datetimeinicio = new System.Windows.Forms.DateTimePicker();
            this.txtplazos = new System.Windows.Forms.TextBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcedula3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtinteres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.generarcuotas = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtobserva
            // 
            this.txtobserva.BackColor = System.Drawing.Color.White;
            this.txtobserva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtobserva.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobserva.ForeColor = System.Drawing.Color.Black;
            this.txtobserva.Location = new System.Drawing.Point(190, 1025);
            this.txtobserva.Multiline = true;
            this.txtobserva.Name = "txtobserva";
            this.txtobserva.Size = new System.Drawing.Size(741, 181);
            this.txtobserva.TabIndex = 9;
            this.txtobserva.TextChanged += new System.EventHandler(this.txttelefono_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(184, 951);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 33);
            this.label8.TabIndex = 8;
            this.label8.Text = "Observaciones:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(184, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 33);
            this.label10.TabIndex = 4;
            this.label10.Text = "Modalidad de Pago:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtmontop
            // 
            this.txtmontop.BackColor = System.Drawing.Color.White;
            this.txtmontop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmontop.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontop.ForeColor = System.Drawing.Color.Black;
            this.txtmontop.Location = new System.Drawing.Point(289, 203);
            this.txtmontop.Name = "txtmontop";
            this.txtmontop.Size = new System.Drawing.Size(741, 40);
            this.txtmontop.TabIndex = 3;
            this.txtmontop.TextChanged += new System.EventHandler(this.txtcedula_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(477, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 33);
            this.label11.TabIndex = 2;
            this.label11.Text = "Monto Principal:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(137, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(268, 37);
            this.label12.TabIndex = 0;
            this.label12.Text = "Registar Crédito";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cbmodalidad
            // 
            this.cbmodalidad.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmodalidad.FormattingEnabled = true;
            this.cbmodalidad.Items.AddRange(new object[] {
            "PAGO UNICO",
            "CUOTAS"});
            this.cbmodalidad.Location = new System.Drawing.Point(190, 380);
            this.cbmodalidad.Name = "cbmodalidad";
            this.cbmodalidad.Size = new System.Drawing.Size(270, 41);
            this.cbmodalidad.TabIndex = 10;
            this.cbmodalidad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbfrecuencia
            // 
            this.cbfrecuencia.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfrecuencia.FormattingEnabled = true;
            this.cbfrecuencia.Items.AddRange(new object[] {
            "SEMANAL",
            "QUINCENAL",
            "MENSUAL"});
            this.cbfrecuencia.Location = new System.Drawing.Point(783, 378);
            this.cbfrecuencia.Name = "cbfrecuencia";
            this.cbfrecuencia.Size = new System.Drawing.Size(270, 41);
            this.cbfrecuencia.TabIndex = 12;
            this.cbfrecuencia.Visible = false;
            this.cbfrecuencia.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(777, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Frecuencia de Pagos:";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(688, 747);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Número de cuotas:";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(184, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 33);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fecha de Cobro:";
            // 
            // datetimeinicio
            // 
            this.datetimeinicio.CalendarFont = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeinicio.Location = new System.Drawing.Point(166, 604);
            this.datetimeinicio.Name = "datetimeinicio";
            this.datetimeinicio.Size = new System.Drawing.Size(497, 39);
            this.datetimeinicio.TabIndex = 17;
            this.datetimeinicio.ValueChanged += new System.EventHandler(this.datetimes_ValueChanged);
            // 
            // txtplazos
            // 
            this.txtplazos.BackColor = System.Drawing.Color.White;
            this.txtplazos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtplazos.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplazos.ForeColor = System.Drawing.Color.Black;
            this.txtplazos.Location = new System.Drawing.Point(694, 822);
            this.txtplazos.Name = "txtplazos";
            this.txtplazos.Size = new System.Drawing.Size(205, 40);
            this.txtplazos.TabIndex = 19;
            this.txtplazos.Visible = false;
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.Beige;
            this.gb1.Controls.Add(this.btBuscar);
            this.gb1.Controls.Add(this.label6);
            this.gb1.Controls.Add(this.txtcedula3);
            this.gb1.Controls.Add(this.label7);
            this.gb1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gb1.Location = new System.Drawing.Point(1438, 105);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(700, 274);
            this.gb1.TabIndex = 20;
            this.gb1.TabStop = false;
            this.gb1.Enter += new System.EventHandler(this.gb1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(244, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 37);
            this.label6.TabIndex = 21;
            this.label6.Text = "Buscar cliente";
            // 
            // txtcedula3
            // 
            this.txtcedula3.BackColor = System.Drawing.Color.White;
            this.txtcedula3.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcedula3.ForeColor = System.Drawing.Color.Black;
            this.txtcedula3.Location = new System.Drawing.Point(164, 125);
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
            // txtinteres
            // 
            this.txtinteres.BackColor = System.Drawing.Color.White;
            this.txtinteres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtinteres.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinteres.ForeColor = System.Drawing.Color.Black;
            this.txtinteres.Location = new System.Drawing.Point(190, 822);
            this.txtinteres.Name = "txtinteres";
            this.txtinteres.Size = new System.Drawing.Size(205, 40);
            this.txtinteres.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(184, 752);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 33);
            this.label5.TabIndex = 22;
            this.label5.Text = "Interese:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(401, 825);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 33);
            this.label9.TabIndex = 24;
            this.label9.Text = "%";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::Capa_presentacion.Properties.Resources.recargar;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1111, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 52);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // generarcuotas
            // 
            this.generarcuotas.BackColor = System.Drawing.Color.White;
            this.generarcuotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.generarcuotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generarcuotas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generarcuotas.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarcuotas.ForeColor = System.Drawing.Color.Black;
            this.generarcuotas.Image = global::Capa_presentacion.Properties.Resources.dinero;
            this.generarcuotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generarcuotas.Location = new System.Drawing.Point(1321, 1182);
            this.generarcuotas.Name = "generarcuotas";
            this.generarcuotas.Size = new System.Drawing.Size(264, 63);
            this.generarcuotas.TabIndex = 25;
            this.generarcuotas.Text = "Generar cuotas";
            this.generarcuotas.UseVisualStyleBackColor = false;
            this.generarcuotas.Visible = false;
            this.generarcuotas.Click += new System.EventHandler(this.modificar_Click);
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
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.White;
            this.guardar.BackgroundImage = global::Capa_presentacion.Properties.Resources.guardar_el_archivo;
            this.guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guardar.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.Color.White;
            this.guardar.Location = new System.Drawing.Point(430, 1324);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(592, 78);
            this.guardar.TabIndex = 9;
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Capa_presentacion.Properties.Resources.colateral__1_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(15, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 117);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Registrar_creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1915, 1050);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.generarcuotas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtinteres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.txtplazos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datetimeinicio);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbfrecuencia);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbmodalidad);
            this.Controls.Add(this.txtmontop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtobserva);
            this.Controls.Add(this.label8);
            this.Name = "Registrar_creditos";
            this.Load += new System.EventHandler(this.Registrar_creditos_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.TextBox txtobserva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmontop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbmodalidad;
        private System.Windows.Forms.ComboBox cbfrecuencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datetimeinicio;
        private System.Windows.Forms.TextBox txtplazos;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcedula3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtinteres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button generarcuotas;
        private System.Windows.Forms.Button button3;
    }
}