namespace Capa_presentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.sliderbar = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label_show_usuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.verUsuario = new System.Windows.Forms.TextBox();
            this.panelc = new System.Windows.Forms.Panel();
            this.principal = new ReaLTaiizor.Controls.Panel();
            this.modificarcliente = new System.Windows.Forms.Button();
            this.registrarcliente = new System.Windows.Forms.Button();
            this.btusuarios = new System.Windows.Forms.Button();
            this.btrees = new System.Windows.Forms.Button();
            this.btcuotas = new System.Windows.Forms.Button();
            this.btpagos = new System.Windows.Forms.Button();
            this.btcreditos = new System.Windows.Forms.Button();
            this.btcliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(494, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema De Creditos";
            // 
            // sliderbar
            // 
            this.sliderbar.Interval = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(1196, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 5;
            // 
            // label_show_usuario
            // 
            this.label_show_usuario.AutoSize = true;
            this.label_show_usuario.BackColor = System.Drawing.Color.White;
            this.label_show_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_usuario.ForeColor = System.Drawing.Color.SeaGreen;
            this.label_show_usuario.Location = new System.Drawing.Point(1216, 19);
            this.label_show_usuario.Name = "label_show_usuario";
            this.label_show_usuario.Size = new System.Drawing.Size(0, 25);
            this.label_show_usuario.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.btusuarios);
            this.panel1.Controls.Add(this.btrees);
            this.panel1.Controls.Add(this.btcuotas);
            this.panel1.Controls.Add(this.btpagos);
            this.panel1.Controls.Add(this.btcreditos);
            this.panel1.Controls.Add(this.btcliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 1049);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(142, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 56);
            this.label3.TabIndex = 1;
            this.label3.Text = "AgroSan";
            // 
            // verUsuario
            // 
            this.verUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verUsuario.Location = new System.Drawing.Point(1711, 27);
            this.verUsuario.Name = "verUsuario";
            this.verUsuario.ReadOnly = true;
            this.verUsuario.Size = new System.Drawing.Size(180, 35);
            this.verUsuario.TabIndex = 9;
            // 
            // panelc
            // 
            this.panelc.BackColor = System.Drawing.Color.SeaGreen;
            this.panelc.Controls.Add(this.modificarcliente);
            this.panelc.Controls.Add(this.registrarcliente);
            this.panelc.Location = new System.Drawing.Point(483, 221);
            this.panelc.Name = "panelc";
            this.panelc.Size = new System.Drawing.Size(301, 148);
            this.panelc.TabIndex = 0;
            this.panelc.Visible = false;
            this.panelc.Paint += new System.Windows.Forms.PaintEventHandler(this.panelc_Paint);
            // 
            // principal
            // 
            this.principal.BackColor = System.Drawing.Color.White;
            this.principal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.principal.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.principal.Location = new System.Drawing.Point(483, 79);
            this.principal.Name = "principal";
            this.principal.Padding = new System.Windows.Forms.Padding(5);
            this.principal.Size = new System.Drawing.Size(1408, 946);
            this.principal.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.principal.TabIndex = 7;
            this.principal.Text = "panel1";
            // 
            // modificarcliente
            // 
            this.modificarcliente.BackColor = System.Drawing.Color.SeaGreen;
            this.modificarcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.modificarcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarcliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarcliente.ForeColor = System.Drawing.Color.White;
            this.modificarcliente.Location = new System.Drawing.Point(18, 75);
            this.modificarcliente.Name = "modificarcliente";
            this.modificarcliente.Size = new System.Drawing.Size(265, 51);
            this.modificarcliente.TabIndex = 9;
            this.modificarcliente.Text = "  Modificar clientes";
            this.modificarcliente.UseVisualStyleBackColor = false;
            // 
            // registrarcliente
            // 
            this.registrarcliente.BackColor = System.Drawing.Color.SeaGreen;
            this.registrarcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registrarcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarcliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarcliente.ForeColor = System.Drawing.Color.White;
            this.registrarcliente.Location = new System.Drawing.Point(18, 18);
            this.registrarcliente.Name = "registrarcliente";
            this.registrarcliente.Size = new System.Drawing.Size(265, 51);
            this.registrarcliente.TabIndex = 8;
            this.registrarcliente.Text = "  Registrar clientes";
            this.registrarcliente.UseVisualStyleBackColor = false;
            this.registrarcliente.Click += new System.EventHandler(this.button7_Click);
            // 
            // btusuarios
            // 
            this.btusuarios.BackColor = System.Drawing.Color.SeaGreen;
            this.btusuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btusuarios.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btusuarios.Image = global::Capa_presentacion.Properties.Resources.usuario;
            this.btusuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btusuarios.Location = new System.Drawing.Point(11, 902);
            this.btusuarios.Name = "btusuarios";
            this.btusuarios.Size = new System.Drawing.Size(450, 111);
            this.btusuarios.TabIndex = 7;
            this.btusuarios.Text = "    Usuarios";
            this.btusuarios.UseVisualStyleBackColor = false;
            // 
            // btrees
            // 
            this.btrees.BackColor = System.Drawing.Color.SeaGreen;
            this.btrees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrees.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrees.Image = global::Capa_presentacion.Properties.Resources.calendario__1_;
            this.btrees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btrees.Location = new System.Drawing.Point(11, 768);
            this.btrees.Name = "btrees";
            this.btrees.Size = new System.Drawing.Size(450, 111);
            this.btrees.TabIndex = 6;
            this.btrees.Text = "       Reestructuración";
            this.btrees.UseVisualStyleBackColor = false;
            this.btrees.Click += new System.EventHandler(this.btrees_Click);
            // 
            // btcuotas
            // 
            this.btcuotas.BackColor = System.Drawing.Color.SeaGreen;
            this.btcuotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcuotas.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcuotas.Image = global::Capa_presentacion.Properties.Resources.pago;
            this.btcuotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcuotas.Location = new System.Drawing.Point(11, 636);
            this.btcuotas.Name = "btcuotas";
            this.btcuotas.Size = new System.Drawing.Size(450, 111);
            this.btcuotas.TabIndex = 5;
            this.btcuotas.Text = "    Cuotas";
            this.btcuotas.UseVisualStyleBackColor = false;
            // 
            // btpagos
            // 
            this.btpagos.BackColor = System.Drawing.Color.SeaGreen;
            this.btpagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btpagos.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpagos.Image = global::Capa_presentacion.Properties.Resources.caja_registradora;
            this.btpagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btpagos.Location = new System.Drawing.Point(11, 510);
            this.btpagos.Name = "btpagos";
            this.btpagos.Size = new System.Drawing.Size(450, 111);
            this.btpagos.TabIndex = 4;
            this.btpagos.Text = "    Pagos";
            this.btpagos.UseVisualStyleBackColor = false;
            // 
            // btcreditos
            // 
            this.btcreditos.BackColor = System.Drawing.Color.SeaGreen;
            this.btcreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcreditos.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcreditos.Image = global::Capa_presentacion.Properties.Resources.edificio_del_banco__1_;
            this.btcreditos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcreditos.Location = new System.Drawing.Point(11, 378);
            this.btcreditos.Name = "btcreditos";
            this.btcreditos.Size = new System.Drawing.Size(450, 111);
            this.btcreditos.TabIndex = 3;
            this.btcreditos.Text = "     Créditos";
            this.btcreditos.UseVisualStyleBackColor = false;
            this.btcreditos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btcliente
            // 
            this.btcliente.BackColor = System.Drawing.Color.SeaGreen;
            this.btcliente.BackgroundImage = global::Capa_presentacion.Properties.Resources.avatar_de_usuario__2_;
            this.btcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcliente.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcliente.ForeColor = System.Drawing.Color.White;
            this.btcliente.Location = new System.Drawing.Point(11, 247);
            this.btcliente.Name = "btcliente";
            this.btcliente.Size = new System.Drawing.Size(450, 111);
            this.btcliente.TabIndex = 2;
            this.btcliente.Text = "   Clientes";
            this.btcliente.UseVisualStyleBackColor = false;
            this.btcliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Capa_presentacion.Properties.Resources.ChatGPT_Image_22_oct_2025__04_34_07_p_m_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-17, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 152);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1046);
            this.Controls.Add(this.panelc);
            this.Controls.Add(this.verUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.principal);
            this.Controls.Add(this.label_show_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Inicio";
            this.Text = "SISTEMA DE CREDITOS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sliderbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_show_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btcliente;
        private System.Windows.Forms.Button btcreditos;
        private System.Windows.Forms.Button btpagos;
        private System.Windows.Forms.Button btcuotas;
        private System.Windows.Forms.Button btrees;
        private System.Windows.Forms.Button btusuarios;
        private System.Windows.Forms.TextBox verUsuario;
        private System.Windows.Forms.Button registrarcliente;
        private System.Windows.Forms.Panel panelc;
        private System.Windows.Forms.Button modificarcliente;
        private ReaLTaiizor.Controls.Panel principal;
    }
}

