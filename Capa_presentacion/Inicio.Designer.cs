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
            this.verUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btusuarios = new System.Windows.Forms.Button();
            this.btpagos = new System.Windows.Forms.Button();
            this.btrees = new System.Windows.Forms.Button();
            this.btcuotas = new System.Windows.Forms.Button();
            this.btcreditos = new System.Windows.Forms.Button();
            this.btcliente = new System.Windows.Forms.Button();
            this.principal = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(18, 16);
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
            this.panel1.Controls.Add(this.verUsuario);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btusuarios);
            this.panel1.Controls.Add(this.btpagos);
            this.panel1.Controls.Add(this.btrees);
            this.panel1.Controls.Add(this.btcuotas);
            this.panel1.Controls.Add(this.btcreditos);
            this.panel1.Controls.Add(this.btcliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 1046);
            this.panel1.TabIndex = 9;
            // 
            // verUsuario
            // 
            this.verUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.verUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verUsuario.Location = new System.Drawing.Point(0, 1011);
            this.verUsuario.Name = "verUsuario";
            this.verUsuario.ReadOnly = true;
            this.verUsuario.Size = new System.Drawing.Size(488, 35);
            this.verUsuario.TabIndex = 9;
            this.verUsuario.TextChanged += new System.EventHandler(this.verUsuario_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 210);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(89, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 56);
            this.label3.TabIndex = 1;
            this.label3.Text = "AgroSan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Capa_presentacion.Properties.Resources.ChatGPT_Image_22_oct_2025__04_34_07_p_m_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(150, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 152);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btusuarios
            // 
            this.btusuarios.BackColor = System.Drawing.Color.SeaGreen;
            this.btusuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btusuarios.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btusuarios.Image = global::Capa_presentacion.Properties.Resources.usuario;
            this.btusuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btusuarios.Location = new System.Drawing.Point(19, 898);
            this.btusuarios.Name = "btusuarios";
            this.btusuarios.Size = new System.Drawing.Size(450, 111);
            this.btusuarios.TabIndex = 7;
            this.btusuarios.Text = "    Usuarios";
            this.btusuarios.UseVisualStyleBackColor = false;
            // 
            // btpagos
            // 
            this.btpagos.BackColor = System.Drawing.Color.SeaGreen;
            this.btpagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btpagos.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpagos.Image = global::Capa_presentacion.Properties.Resources.caja_registradora;
            this.btpagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btpagos.Location = new System.Drawing.Point(20, 632);
            this.btpagos.Name = "btpagos";
            this.btpagos.Size = new System.Drawing.Size(450, 111);
            this.btpagos.TabIndex = 4;
            this.btpagos.Text = "    Pagos";
            this.btpagos.UseVisualStyleBackColor = false;
            this.btpagos.Click += new System.EventHandler(this.btpagos_Click);
            // 
            // btrees
            // 
            this.btrees.BackColor = System.Drawing.Color.SeaGreen;
            this.btrees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrees.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrees.Image = global::Capa_presentacion.Properties.Resources.calendario__1_;
            this.btrees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btrees.Location = new System.Drawing.Point(19, 767);
            this.btrees.Name = "btrees";
            this.btrees.Size = new System.Drawing.Size(450, 111);
            this.btrees.TabIndex = 6;
            this.btrees.Text = "       Reestructuración";
            this.btrees.UseVisualStyleBackColor = false;
            // 
            // btcuotas
            // 
            this.btcuotas.BackColor = System.Drawing.Color.SeaGreen;
            this.btcuotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcuotas.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcuotas.Image = global::Capa_presentacion.Properties.Resources.pago;
            this.btcuotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcuotas.Location = new System.Drawing.Point(20, 498);
            this.btcuotas.Name = "btcuotas";
            this.btcuotas.Size = new System.Drawing.Size(450, 111);
            this.btcuotas.TabIndex = 5;
            this.btcuotas.Text = "    Cuotas";
            this.btcuotas.UseVisualStyleBackColor = false;
            this.btcuotas.Click += new System.EventHandler(this.btcuotas_Click_1);
            // 
            // btcreditos
            // 
            this.btcreditos.BackColor = System.Drawing.Color.SeaGreen;
            this.btcreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcreditos.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcreditos.Image = global::Capa_presentacion.Properties.Resources.edificio_del_banco__1_;
            this.btcreditos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcreditos.Location = new System.Drawing.Point(19, 359);
            this.btcreditos.Name = "btcreditos";
            this.btcreditos.Size = new System.Drawing.Size(450, 111);
            this.btcreditos.TabIndex = 3;
            this.btcreditos.Text = "     Créditos";
            this.btcreditos.UseVisualStyleBackColor = false;
            this.btcreditos.Click += new System.EventHandler(this.btcreditos_Click);
            // 
            // btcliente
            // 
            this.btcliente.BackColor = System.Drawing.Color.SeaGreen;
            this.btcliente.BackgroundImage = global::Capa_presentacion.Properties.Resources.avatar_de_usuario__2_;
            this.btcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcliente.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcliente.ForeColor = System.Drawing.Color.White;
            this.btcliente.Location = new System.Drawing.Point(23, 230);
            this.btcliente.Name = "btcliente";
            this.btcliente.Size = new System.Drawing.Size(450, 111);
            this.btcliente.TabIndex = 2;
            this.btcliente.Text = "   Clientes";
            this.btcliente.UseVisualStyleBackColor = false;
            this.btcliente.Click += new System.EventHandler(this.btcliente_Click);
            // 
            // principal
            // 
            this.principal.BackColor = System.Drawing.Color.White;
            this.principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.principal.Location = new System.Drawing.Point(488, 121);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(1432, 925);
            this.principal.TabIndex = 10;
            this.principal.Paint += new System.Windows.Forms.PaintEventHandler(this.principal_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Beige;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(488, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1432, 121);
            this.panel3.TabIndex = 11;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1046);
            this.Controls.Add(this.principal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_show_usuario);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Inicio";
            this.Text = "SISTEMA DE CREDITOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sliderbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_show_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btusuarios;
        private System.Windows.Forms.Button btpagos;
        private System.Windows.Forms.Button btrees;
        private System.Windows.Forms.Button btcuotas;
        private System.Windows.Forms.Button btcreditos;
        private System.Windows.Forms.Button btcliente;
        private System.Windows.Forms.TextBox verUsuario;
        private System.Windows.Forms.Panel principal;
        private System.Windows.Forms.Panel panel3;
    }
}

