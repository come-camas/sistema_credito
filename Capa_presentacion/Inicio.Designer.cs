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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_C = new FontAwesome.Sharp.IconMenuItem();
            this.submenu_venta_registrar = new FontAwesome.Sharp.IconMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Creditos = new FontAwesome.Sharp.IconMenuItem();
            this.submenu_compra_registrar = new FontAwesome.Sharp.IconMenuItem();
            this.menu_cuotas = new FontAwesome.Sharp.IconMenuItem();
            this.submenu_mantenedor_categoria = new FontAwesome.Sharp.IconMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_pagos = new FontAwesome.Sharp.IconMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_restructuraciones = new FontAwesome.Sharp.IconMenuItem();
            this.menu_reporte = new FontAwesome.Sharp.IconMenuItem();
            this.menu_usuario = new FontAwesome.Sharp.IconMenuItem();
            this.menu_titulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.sliderbar = new System.Windows.Forms.Timer(this.components);
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_show_usuario = new System.Windows.Forms.Label();
            this.barra = new FontAwesome.Sharp.IconPictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barra)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.Ivory;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_C,
            this.menu_Creditos,
            this.menu_cuotas,
            this.menu_pagos,
            this.menu_restructuraciones,
            this.menu_reporte,
            this.menu_usuario});
            this.menu.Location = new System.Drawing.Point(0, 83);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(170, 943);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menu_C
            // 
            this.menu_C.AutoSize = false;
            this.menu_C.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_venta_registrar,
            this.consultarToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menu_C.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menu_C.IconColor = System.Drawing.Color.Black;
            this.menu_C.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_C.IconSize = 50;
            this.menu_C.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_C.Name = "menu_C";
            this.menu_C.Size = new System.Drawing.Size(170, 80);
            this.menu_C.Text = "Clientes";
            this.menu_C.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenu_venta_registrar
            // 
            this.submenu_venta_registrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenu_venta_registrar.IconColor = System.Drawing.Color.Black;
            this.submenu_venta_registrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenu_venta_registrar.Name = "submenu_venta_registrar";
            this.submenu_venta_registrar.Size = new System.Drawing.Size(189, 34);
            this.submenu_venta_registrar.Text = "Registrar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // menu_Creditos
            // 
            this.menu_Creditos.AutoSize = false;
            this.menu_Creditos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_compra_registrar});
            this.menu_Creditos.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.menu_Creditos.IconColor = System.Drawing.Color.Black;
            this.menu_Creditos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_Creditos.IconSize = 50;
            this.menu_Creditos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_Creditos.Name = "menu_Creditos";
            this.menu_Creditos.Size = new System.Drawing.Size(170, 80);
            this.menu_Creditos.Text = "Creditos";
            this.menu_Creditos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenu_compra_registrar
            // 
            this.submenu_compra_registrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenu_compra_registrar.IconColor = System.Drawing.Color.Black;
            this.submenu_compra_registrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenu_compra_registrar.Name = "submenu_compra_registrar";
            this.submenu_compra_registrar.Size = new System.Drawing.Size(182, 34);
            this.submenu_compra_registrar.Text = "Solicitud";
            // 
            // menu_cuotas
            // 
            this.menu_cuotas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_mantenedor_categoria,
            this.consultarToolStripMenuItem1});
            this.menu_cuotas.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.menu_cuotas.IconColor = System.Drawing.Color.Black;
            this.menu_cuotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_cuotas.IconSize = 55;
            this.menu_cuotas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_cuotas.Name = "menu_cuotas";
            this.menu_cuotas.Size = new System.Drawing.Size(163, 84);
            this.menu_cuotas.Text = "Cuotas";
            this.menu_cuotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenu_mantenedor_categoria
            // 
            this.submenu_mantenedor_categoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenu_mantenedor_categoria.IconColor = System.Drawing.Color.Black;
            this.submenu_mantenedor_categoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenu_mantenedor_categoria.Name = "submenu_mantenedor_categoria";
            this.submenu_mantenedor_categoria.Size = new System.Drawing.Size(202, 34);
            this.submenu_mantenedor_categoria.Text = "Generacion";
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(202, 34);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // menu_pagos
            // 
            this.menu_pagos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.consultarToolStripMenuItem2});
            this.menu_pagos.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.menu_pagos.IconColor = System.Drawing.Color.Black;
            this.menu_pagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_pagos.IconSize = 50;
            this.menu_pagos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_pagos.Name = "menu_pagos";
            this.menu_pagos.Size = new System.Drawing.Size(163, 79);
            this.menu_pagos.Text = "Pagos";
            this.menu_pagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // consultarToolStripMenuItem2
            // 
            this.consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            this.consultarToolStripMenuItem2.Size = new System.Drawing.Size(189, 34);
            this.consultarToolStripMenuItem2.Text = "Consultar";
            // 
            // menu_restructuraciones
            // 
            this.menu_restructuraciones.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            this.menu_restructuraciones.IconColor = System.Drawing.Color.Black;
            this.menu_restructuraciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_restructuraciones.IconSize = 50;
            this.menu_restructuraciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_restructuraciones.Name = "menu_restructuraciones";
            this.menu_restructuraciones.Size = new System.Drawing.Size(163, 79);
            this.menu_restructuraciones.Text = "Restructuraciones";
            this.menu_restructuraciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_reporte
            // 
            this.menu_reporte.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menu_reporte.IconColor = System.Drawing.Color.Black;
            this.menu_reporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_reporte.IconSize = 50;
            this.menu_reporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_reporte.Name = "menu_reporte";
            this.menu_reporte.Size = new System.Drawing.Size(163, 79);
            this.menu_reporte.Text = "Reportes";
            this.menu_reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_usuario
            // 
            this.menu_usuario.IconChar = FontAwesome.Sharp.IconChar.User;
            this.menu_usuario.IconColor = System.Drawing.Color.Black;
            this.menu_usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_usuario.IconSize = 50;
            this.menu_usuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_usuario.Name = "menu_usuario";
            this.menu_usuario.Size = new System.Drawing.Size(163, 79);
            this.menu_usuario.Text = "Usuarios";
            this.menu_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_titulo
            // 
            this.menu_titulo.AutoSize = false;
            this.menu_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.menu_titulo.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu_titulo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_titulo.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.menu_titulo.Location = new System.Drawing.Point(0, 0);
            this.menu_titulo.Name = "menu_titulo";
            this.menu_titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu_titulo.Size = new System.Drawing.Size(1593, 83);
            this.menu_titulo.TabIndex = 1;
            this.menu_titulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(87, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema De Creditos";
            // 
            // sliderbar
            // 
            this.sliderbar.Interval = 20;
            this.sliderbar.Tick += new System.EventHandler(this.sliderbar_Tick_1);
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.contenedor.Location = new System.Drawing.Point(170, 83);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1423, 943);
            this.contenedor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1120, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario: ";
            // 
            // label_show_usuario
            // 
            this.label_show_usuario.AutoSize = true;
            this.label_show_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_show_usuario.Location = new System.Drawing.Point(1221, 30);
            this.label_show_usuario.Name = "label_show_usuario";
            this.label_show_usuario.Size = new System.Drawing.Size(90, 25);
            this.label_show_usuario.TabIndex = 6;
            this.label_show_usuario.Text = "Usuario: ";
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.barra.ForeColor = System.Drawing.SystemColors.Control;
            this.barra.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.barra.IconColor = System.Drawing.SystemColors.Control;
            this.barra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.barra.IconSize = 55;
            this.barra.Location = new System.Drawing.Point(26, 12);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(55, 55);
            this.barra.TabIndex = 0;
            this.barra.TabStop = false;
            this.barra.Click += new System.EventHandler(this.barra_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1593, 1026);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.label_show_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menu_titulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menu_titulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menu_reporte;
        private FontAwesome.Sharp.IconMenuItem menu_usuario;
        private FontAwesome.Sharp.IconMenuItem menu_cuotas;
        private FontAwesome.Sharp.IconMenuItem menu_pagos;
        private FontAwesome.Sharp.IconMenuItem menu_restructuraciones;
        private FontAwesome.Sharp.IconMenuItem menu_C;
        private FontAwesome.Sharp.IconMenuItem menu_Creditos;
        private System.Windows.Forms.Timer sliderbar;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_show_usuario;
        private FontAwesome.Sharp.IconMenuItem submenu_mantenedor_categoria;
        private FontAwesome.Sharp.IconMenuItem submenu_venta_registrar;
        private FontAwesome.Sharp.IconMenuItem submenu_compra_registrar;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem2;
        private FontAwesome.Sharp.IconPictureBox barra;
    }
}

