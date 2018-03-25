namespace EASystem
{
	partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbTbarHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoTelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zonaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parentezcoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numeraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbTbarHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 401);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(756, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbTbarHora
            // 
            this.lbTbarHora.Name = "lbTbarHora";
            this.lbTbarHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTbarHora.Size = new System.Drawing.Size(40, 17);
            this.lbTbarHora.Text = "HORA";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.utilidadesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.cobradorToolStripMenuItem,
            this.toolStripSeparator1,
            this.sectorToolStripMenuItem,
            this.ciudadToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem1});
            this.mantenimientosToolStripMenuItem.Image = global::EASystem.Properties.Resources.instrumentos_24;
            this.mantenimientosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::EASystem.Properties.Resources.Clientes_24;
            this.clientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(149, 30);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // cobradorToolStripMenuItem
            // 
            this.cobradorToolStripMenuItem.Image = global::EASystem.Properties.Resources.cobrador_24x24;
            this.cobradorToolStripMenuItem.Name = "cobradorToolStripMenuItem";
            this.cobradorToolStripMenuItem.Size = new System.Drawing.Size(149, 30);
            this.cobradorToolStripMenuItem.Text = "Cobrador";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // sectorToolStripMenuItem
            // 
            this.sectorToolStripMenuItem.Image = global::EASystem.Properties.Resources.barrio_24;
            this.sectorToolStripMenuItem.Name = "sectorToolStripMenuItem";
            this.sectorToolStripMenuItem.Size = new System.Drawing.Size(149, 30);
            this.sectorToolStripMenuItem.Text = "Sector";
            this.sectorToolStripMenuItem.Click += new System.EventHandler(this.sectorToolStripMenuItem_Click);
            // 
            // ciudadToolStripMenuItem
            // 
            this.ciudadToolStripMenuItem.Image = global::EASystem.Properties.Resources.ciudad_24;
            this.ciudadToolStripMenuItem.Name = "ciudadToolStripMenuItem";
            this.ciudadToolStripMenuItem.Size = new System.Drawing.Size(149, 30);
            this.ciudadToolStripMenuItem.Text = "Ciudad";
            this.ciudadToolStripMenuItem.Click += new System.EventHandler(this.ciudadToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoTelToolStripMenuItem,
            this.zonaToolStripMenuItem1,
            this.parentezcoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 30);
            this.toolStripMenuItem1.Text = "Tablillas";
            // 
            // tipoTelToolStripMenuItem
            // 
            this.tipoTelToolStripMenuItem.Image = global::EASystem.Properties.Resources.receptor_del_telefono;
            this.tipoTelToolStripMenuItem.Name = "tipoTelToolStripMenuItem";
            this.tipoTelToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.tipoTelToolStripMenuItem.Text = "Tipo Teléfono";
            this.tipoTelToolStripMenuItem.Click += new System.EventHandler(this.tipoTelToolStripMenuItem_Click);
            // 
            // zonaToolStripMenuItem1
            // 
            this.zonaToolStripMenuItem1.Image = global::EASystem.Properties.Resources.zone_24x24;
            this.zonaToolStripMenuItem1.Name = "zonaToolStripMenuItem1";
            this.zonaToolStripMenuItem1.Size = new System.Drawing.Size(170, 24);
            this.zonaToolStripMenuItem1.Text = "Zona";
            this.zonaToolStripMenuItem1.Click += new System.EventHandler(this.zonaToolStripMenuItem1_Click);
            // 
            // parentezcoToolStripMenuItem
            // 
            this.parentezcoToolStripMenuItem.Name = "parentezcoToolStripMenuItem";
            this.parentezcoToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.parentezcoToolStripMenuItem.Text = "Parentezco";
            this.parentezcoToolStripMenuItem.Click += new System.EventHandler(this.parentezcoToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.informesToolStripMenuItem.Text = "Reportes";
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearPrestamosToolStripMenuItem});
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(89, 28);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // crearPrestamosToolStripMenuItem
            // 
            this.crearPrestamosToolStripMenuItem.Name = "crearPrestamosToolStripMenuItem";
            this.crearPrestamosToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.crearPrestamosToolStripMenuItem.Text = "Crear prestamos";
            this.crearPrestamosToolStripMenuItem.Click += new System.EventHandler(this.crearPrestamosToolStripMenuItem_Click);
            // 
            // utilidadesToolStripMenuItem
            // 
            this.utilidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numeraciónToolStripMenuItem});
            this.utilidadesToolStripMenuItem.Name = "utilidadesToolStripMenuItem";
            this.utilidadesToolStripMenuItem.Size = new System.Drawing.Size(95, 28);
            this.utilidadesToolStripMenuItem.Text = "Parametros";
            // 
            // numeraciónToolStripMenuItem
            // 
            this.numeraciónToolStripMenuItem.Name = "numeraciónToolStripMenuItem";
            this.numeraciónToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.numeraciónToolStripMenuItem.Text = "Numeración";
            this.numeraciónToolStripMenuItem.Click += new System.EventHandler(this.numeraciónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 28);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::EASystem.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(756, 423);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "PRESTAME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lbTbarHora;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cobradorToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem sectorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ciudadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem utilidadesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem numeraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tipoTelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zonaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parentezcoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPrestamosToolStripMenuItem;
    }
}