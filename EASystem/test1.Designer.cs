namespace EASystem
{
    partial class frmPrincipal1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal1));
			this.pnMenu = new System.Windows.Forms.Panel();
			this.btnCxp = new System.Windows.Forms.Button();
			this.btnCxC = new System.Windows.Forms.Button();
			this.btnInventario = new System.Windows.Forms.Button();
			this.pnUser = new System.Windows.Forms.Panel();
			this.pnInv = new System.Windows.Forms.Panel();
			this.btnInvSalir = new System.Windows.Forms.Button();
			this.btnMenIUtil = new System.Windows.Forms.Button();
			this.btnMenInv = new System.Windows.Forms.Button();
			this.btnMenVentas = new System.Windows.Forms.Button();
			this.btnMenReport = new System.Windows.Forms.Button();
			this.btnMenEntradas = new System.Windows.Forms.Button();
			this.pnCxc = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.pnCxp = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.pnCont = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.pnContainer = new System.Windows.Forms.Panel();
			this.pnMenu.SuspendLayout();
			this.pnInv.SuspendLayout();
			this.pnCxc.SuspendLayout();
			this.pnCxp.SuspendLayout();
			this.pnCont.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnMenu
			// 
			this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(134)))), ((int)(((byte)(200)))));
			this.pnMenu.Controls.Add(this.btnCxp);
			this.pnMenu.Controls.Add(this.btnCxC);
			this.pnMenu.Controls.Add(this.btnInventario);
			this.pnMenu.Controls.Add(this.pnUser);
			this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnMenu.Location = new System.Drawing.Point(0, 0);
			this.pnMenu.Name = "pnMenu";
			this.pnMenu.Size = new System.Drawing.Size(164, 497);
			this.pnMenu.TabIndex = 2;
			// 
			// btnCxp
			// 
			this.btnCxp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(134)))), ((int)(((byte)(200)))));
			this.btnCxp.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCxp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(134)))), ((int)(((byte)(200)))));
			this.btnCxp.FlatAppearance.BorderSize = 2;
			this.btnCxp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnCxp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
			this.btnCxp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCxp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCxp.ForeColor = System.Drawing.Color.White;
			this.btnCxp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCxp.Location = new System.Drawing.Point(0, 219);
			this.btnCxp.Name = "btnCxp";
			this.btnCxp.Size = new System.Drawing.Size(164, 40);
			this.btnCxp.TabIndex = 6;
			this.btnCxp.Text = "Cuentas x Pagar";
			this.btnCxp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCxp.UseVisualStyleBackColor = false;
			this.btnCxp.Click += new System.EventHandler(this.btnCxp_Click);
			// 
			// btnCxC
			// 
			this.btnCxC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(134)))), ((int)(((byte)(200)))));
			this.btnCxC.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCxC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(134)))), ((int)(((byte)(200)))));
			this.btnCxC.FlatAppearance.BorderSize = 2;
			this.btnCxC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnCxC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
			this.btnCxC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCxC.ForeColor = System.Drawing.Color.White;
			this.btnCxC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCxC.Location = new System.Drawing.Point(0, 179);
			this.btnCxC.Name = "btnCxC";
			this.btnCxC.Size = new System.Drawing.Size(164, 40);
			this.btnCxC.TabIndex = 5;
			this.btnCxC.Text = "Cuentas x Cobrar";
			this.btnCxC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCxC.UseVisualStyleBackColor = false;
			this.btnCxC.Click += new System.EventHandler(this.btnCxC_Click);
			// 
			// btnInventario
			// 
			this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(134)))), ((int)(((byte)(200)))));
			this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnInventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(134)))), ((int)(((byte)(200)))));
			this.btnInventario.FlatAppearance.BorderSize = 2;
			this.btnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
			this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInventario.ForeColor = System.Drawing.Color.White;
			this.btnInventario.Image = global::EASystem.Properties.Resources.Trolley_24px;
			this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInventario.Location = new System.Drawing.Point(0, 139);
			this.btnInventario.Name = "btnInventario";
			this.btnInventario.Size = new System.Drawing.Size(164, 40);
			this.btnInventario.TabIndex = 4;
			this.btnInventario.Text = "Inventario";
			this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInventario.UseVisualStyleBackColor = false;
			this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
			// 
			// pnUser
			// 
			this.pnUser.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnUser.Location = new System.Drawing.Point(0, 0);
			this.pnUser.Name = "pnUser";
			this.pnUser.Size = new System.Drawing.Size(164, 139);
			this.pnUser.TabIndex = 0;
			// 
			// pnInv
			// 
			this.pnInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
			this.pnInv.Controls.Add(this.btnInvSalir);
			this.pnInv.Controls.Add(this.btnMenIUtil);
			this.pnInv.Controls.Add(this.btnMenInv);
			this.pnInv.Controls.Add(this.btnMenVentas);
			this.pnInv.Controls.Add(this.btnMenReport);
			this.pnInv.Controls.Add(this.btnMenEntradas);
			this.pnInv.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnInv.Location = new System.Drawing.Point(164, 0);
			this.pnInv.Name = "pnInv";
			this.pnInv.Size = new System.Drawing.Size(808, 40);
			this.pnInv.TabIndex = 6;
			// 
			// btnInvSalir
			// 
			this.btnInvSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
			this.btnInvSalir.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnInvSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
			this.btnInvSalir.FlatAppearance.BorderSize = 2;
			this.btnInvSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
			this.btnInvSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(129)))), ((int)(((byte)(249)))));
			this.btnInvSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInvSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInvSalir.ForeColor = System.Drawing.Color.Black;
			this.btnInvSalir.Image = global::EASystem.Properties.Resources.if_xfce_system_exit_23651;
			this.btnInvSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInvSalir.Location = new System.Drawing.Point(700, 0);
			this.btnInvSalir.Name = "btnInvSalir";
			this.btnInvSalir.Size = new System.Drawing.Size(140, 40);
			this.btnInvSalir.TabIndex = 9;
			this.btnInvSalir.Text = "Salir";
			this.btnInvSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInvSalir.UseVisualStyleBackColor = false;
			// 
			// btnMenIUtil
			// 
			this.btnMenIUtil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
			this.btnMenIUtil.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnMenIUtil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
			this.btnMenIUtil.FlatAppearance.BorderSize = 2;
			this.btnMenIUtil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
			this.btnMenIUtil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(129)))), ((int)(((byte)(249)))));
			this.btnMenIUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenIUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenIUtil.ForeColor = System.Drawing.Color.Black;
			this.btnMenIUtil.Image = global::EASystem.Properties.Resources.Swiss_Army_Knife_24px;
			this.btnMenIUtil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMenIUtil.Location = new System.Drawing.Point(560, 0);
			this.btnMenIUtil.Name = "btnMenIUtil";
			this.btnMenIUtil.Size = new System.Drawing.Size(140, 40);
			this.btnMenIUtil.TabIndex = 8;
			this.btnMenIUtil.Text = "Utiles";
			this.btnMenIUtil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMenIUtil.UseVisualStyleBackColor = false;
			// 
			// btnMenInv
			// 
			this.btnMenInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
			this.btnMenInv.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnMenInv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
			this.btnMenInv.FlatAppearance.BorderSize = 2;
			this.btnMenInv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
			this.btnMenInv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(129)))), ((int)(((byte)(249)))));
			this.btnMenInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenInv.ForeColor = System.Drawing.Color.Black;
			this.btnMenInv.Image = global::EASystem.Properties.Resources.Trolley_24px;
			this.btnMenInv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMenInv.Location = new System.Drawing.Point(420, 0);
			this.btnMenInv.Name = "btnMenInv";
			this.btnMenInv.Size = new System.Drawing.Size(140, 40);
			this.btnMenInv.TabIndex = 7;
			this.btnMenInv.Text = "Inventario";
			this.btnMenInv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMenInv.UseVisualStyleBackColor = false;
			// 
			// btnMenVentas
			// 
			this.btnMenVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
			this.btnMenVentas.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnMenVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
			this.btnMenVentas.FlatAppearance.BorderSize = 2;
			this.btnMenVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
			this.btnMenVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(129)))), ((int)(((byte)(249)))));
			this.btnMenVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenVentas.ForeColor = System.Drawing.Color.Black;
			this.btnMenVentas.Image = global::EASystem.Properties.Resources.Sales_Performance_24px;
			this.btnMenVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMenVentas.Location = new System.Drawing.Point(280, 0);
			this.btnMenVentas.Name = "btnMenVentas";
			this.btnMenVentas.Size = new System.Drawing.Size(140, 40);
			this.btnMenVentas.TabIndex = 6;
			this.btnMenVentas.Text = "Ventas";
			this.btnMenVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMenVentas.UseVisualStyleBackColor = false;
			// 
			// btnMenReport
			// 
			this.btnMenReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
			this.btnMenReport.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnMenReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
			this.btnMenReport.FlatAppearance.BorderSize = 2;
			this.btnMenReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
			this.btnMenReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(129)))), ((int)(((byte)(249)))));
			this.btnMenReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenReport.ForeColor = System.Drawing.Color.Black;
			this.btnMenReport.Image = global::EASystem.Properties.Resources.Report_Card_24px;
			this.btnMenReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMenReport.Location = new System.Drawing.Point(140, 0);
			this.btnMenReport.Name = "btnMenReport";
			this.btnMenReport.Size = new System.Drawing.Size(140, 40);
			this.btnMenReport.TabIndex = 5;
			this.btnMenReport.Text = "Reportes";
			this.btnMenReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMenReport.UseVisualStyleBackColor = false;
			// 
			// btnMenEntradas
			// 
			this.btnMenEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
			this.btnMenEntradas.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnMenEntradas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
			this.btnMenEntradas.FlatAppearance.BorderSize = 2;
			this.btnMenEntradas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
			this.btnMenEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(129)))), ((int)(((byte)(249)))));
			this.btnMenEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenEntradas.ForeColor = System.Drawing.Color.Black;
			this.btnMenEntradas.Image = ((System.Drawing.Image)(resources.GetObject("btnMenEntradas.Image")));
			this.btnMenEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMenEntradas.Location = new System.Drawing.Point(0, 0);
			this.btnMenEntradas.Name = "btnMenEntradas";
			this.btnMenEntradas.Size = new System.Drawing.Size(140, 40);
			this.btnMenEntradas.TabIndex = 4;
			this.btnMenEntradas.Text = "Entradas";
			this.btnMenEntradas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMenEntradas.UseVisualStyleBackColor = false;
			this.btnMenEntradas.Click += new System.EventHandler(this.btnMenEntradas_Click);
			// 
			// pnCxc
			// 
			this.pnCxc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.pnCxc.Controls.Add(this.button1);
			this.pnCxc.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnCxc.Location = new System.Drawing.Point(164, 40);
			this.pnCxc.Name = "pnCxc";
			this.pnCxc.Size = new System.Drawing.Size(808, 40);
			this.pnCxc.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button1.Dock = System.Windows.Forms.DockStyle.Left;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button1.FlatAppearance.BorderSize = 2;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(129)))), ((int)(((byte)(249)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 40);
			this.button1.TabIndex = 4;
			this.button1.Text = "CxC";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// pnCxp
			// 
			this.pnCxp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnCxp.Controls.Add(this.button2);
			this.pnCxp.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnCxp.Location = new System.Drawing.Point(164, 80);
			this.pnCxp.Name = "pnCxp";
			this.pnCxp.Size = new System.Drawing.Size(808, 40);
			this.pnCxp.TabIndex = 10;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button2.Dock = System.Windows.Forms.DockStyle.Left;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button2.FlatAppearance.BorderSize = 2;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(129)))), ((int)(((byte)(249)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(140, 40);
			this.button2.TabIndex = 4;
			this.button2.Text = "CxP";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// pnCont
			// 
			this.pnCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnCont.Controls.Add(this.button3);
			this.pnCont.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnCont.Location = new System.Drawing.Point(164, 120);
			this.pnCont.Name = "pnCont";
			this.pnCont.Size = new System.Drawing.Size(808, 40);
			this.pnCont.TabIndex = 11;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button3.Dock = System.Windows.Forms.DockStyle.Left;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button3.FlatAppearance.BorderSize = 2;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(129)))), ((int)(((byte)(249)))));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(0, 0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(140, 40);
			this.button3.TabIndex = 4;
			this.button3.Text = "Contabilidad";
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = false;
			// 
			// pnContainer
			// 
			this.pnContainer.BackColor = System.Drawing.Color.White;
			this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnContainer.Location = new System.Drawing.Point(164, 160);
			this.pnContainer.Name = "pnContainer";
			this.pnContainer.Size = new System.Drawing.Size(808, 337);
			this.pnContainer.TabIndex = 12;
			// 
			// frmPrincipal1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(972, 497);
			this.Controls.Add(this.pnContainer);
			this.Controls.Add(this.pnCont);
			this.Controls.Add(this.pnCxp);
			this.Controls.Add(this.pnCxc);
			this.Controls.Add(this.pnInv);
			this.Controls.Add(this.pnMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.IsMdiContainer = true;
			this.Name = "frmPrincipal1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DashBoard";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.pnMenu.ResumeLayout(false);
			this.pnInv.ResumeLayout(false);
			this.pnCxc.ResumeLayout(false);
			this.pnCxp.ResumeLayout(false);
			this.pnCont.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnInv;
        private System.Windows.Forms.Button btnMenEntradas;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.Button btnCxC;
        private System.Windows.Forms.Panel pnCxc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnCxp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnCont;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.Button btnCxp;
        private System.Windows.Forms.Button btnMenReport;
        private System.Windows.Forms.Button btnMenInv;
        private System.Windows.Forms.Button btnMenVentas;
        private System.Windows.Forms.Button btnInvSalir;
        private System.Windows.Forms.Button btnMenIUtil;
    }
}

