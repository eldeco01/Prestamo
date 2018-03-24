namespace EASystem
{
	partial class frmNumeracion
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tcEnum = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.pnOpSector = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.txtSecNumSig = new System.Windows.Forms.TextBox();
            this.txtPrefijoSec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnOpCiu = new System.Windows.Forms.Panel();
            this.rbCiuAutoNo = new System.Windows.Forms.RadioButton();
            this.rbCiuAutoSi = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCiuNumSig = new System.Windows.Forms.TextBox();
            this.txtCiuPrefijo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnOpZona = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.txtZonaNumS = new System.Windows.Forms.TextBox();
            this.txtPrefZona = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnOpTitel = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitelNunS = new System.Windows.Forms.TextBox();
            this.txtPrefTitel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnOpParent = new System.Windows.Forms.Panel();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.txtParentS = new System.Windows.Forms.TextBox();
            this.txtPreParent = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tcEnum.SuspendLayout();
            this.tp1.SuspendLayout();
            this.pnOpSector.SuspendLayout();
            this.pnOpCiu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnOpZona.SuspendLayout();
            this.pnOpTitel.SuspendLayout();
            this.pnOpParent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::EASystem.Properties.Resources.save_20x20;
            this.btnSalvar.Location = new System.Drawing.Point(184, 374);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 34);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtras.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Image = global::EASystem.Properties.Resources.Undo_24px;
            this.btnAtras.Location = new System.Drawing.Point(289, 374);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(99, 34);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Salir";
            this.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = global::EASystem.Properties.Resources.modify2_22x22;
            this.btnModificar.Location = new System.Drawing.Point(79, 374);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 34);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tcEnum
            // 
            this.tcEnum.Controls.Add(this.tp1);
            this.tcEnum.Controls.Add(this.tabPage1);
            this.tcEnum.Location = new System.Drawing.Point(15, 12);
            this.tcEnum.Name = "tcEnum";
            this.tcEnum.SelectedIndex = 0;
            this.tcEnum.Size = new System.Drawing.Size(498, 356);
            this.tcEnum.TabIndex = 24;
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.pnOpSector);
            this.tp1.Controls.Add(this.txtSecNumSig);
            this.tp1.Controls.Add(this.txtPrefijoSec);
            this.tp1.Controls.Add(this.label6);
            this.tp1.Controls.Add(this.pnOpCiu);
            this.tp1.Controls.Add(this.label5);
            this.tp1.Controls.Add(this.txtCiuNumSig);
            this.tp1.Controls.Add(this.txtCiuPrefijo);
            this.tp1.Controls.Add(this.label4);
            this.tp1.Controls.Add(this.label3);
            this.tp1.Controls.Add(this.label2);
            this.tp1.Controls.Add(this.label1);
            this.tp1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp1.Location = new System.Drawing.Point(4, 22);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(490, 330);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Pagina 1";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // pnOpSector
            // 
            this.pnOpSector.Controls.Add(this.radioButton3);
            this.pnOpSector.Controls.Add(this.radioButton4);
            this.pnOpSector.Location = new System.Drawing.Point(238, 72);
            this.pnOpSector.Name = "pnOpSector";
            this.pnOpSector.Size = new System.Drawing.Size(99, 29);
            this.pnOpSector.TabIndex = 34;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(43, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(40, 19);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.Text = "No";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(3, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(36, 19);
            this.radioButton4.TabIndex = 17;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Si";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // txtSecNumSig
            // 
            this.txtSecNumSig.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecNumSig.Location = new System.Drawing.Point(361, 76);
            this.txtSecNumSig.MaxLength = 2;
            this.txtSecNumSig.Name = "txtSecNumSig";
            this.txtSecNumSig.Size = new System.Drawing.Size(110, 21);
            this.txtSecNumSig.TabIndex = 1;
            this.txtSecNumSig.Text = "0";
            this.txtSecNumSig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSecNumSig.TextChanged += new System.EventHandler(this.txtSecNumSig_TextChanged);
            this.txtSecNumSig.Enter += new System.EventHandler(this.txtSecNumSig_Enter);
            // 
            // txtPrefijoSec
            // 
            this.txtPrefijoSec.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrefijoSec.Location = new System.Drawing.Point(135, 76);
            this.txtPrefijoSec.MaxLength = 2;
            this.txtPrefijoSec.Name = "txtPrefijoSec";
            this.txtPrefijoSec.Size = new System.Drawing.Size(64, 21);
            this.txtPrefijoSec.TabIndex = 32;
            this.txtPrefijoSec.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "ID Sector:";
            // 
            // pnOpCiu
            // 
            this.pnOpCiu.Controls.Add(this.rbCiuAutoNo);
            this.pnOpCiu.Controls.Add(this.rbCiuAutoSi);
            this.pnOpCiu.Enabled = false;
            this.pnOpCiu.Location = new System.Drawing.Point(238, 37);
            this.pnOpCiu.Name = "pnOpCiu";
            this.pnOpCiu.Size = new System.Drawing.Size(99, 29);
            this.pnOpCiu.TabIndex = 30;
            // 
            // rbCiuAutoNo
            // 
            this.rbCiuAutoNo.AutoSize = true;
            this.rbCiuAutoNo.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCiuAutoNo.Location = new System.Drawing.Point(43, 3);
            this.rbCiuAutoNo.Name = "rbCiuAutoNo";
            this.rbCiuAutoNo.Size = new System.Drawing.Size(40, 19);
            this.rbCiuAutoNo.TabIndex = 18;
            this.rbCiuAutoNo.TabStop = true;
            this.rbCiuAutoNo.Text = "No";
            this.rbCiuAutoNo.UseVisualStyleBackColor = true;
            // 
            // rbCiuAutoSi
            // 
            this.rbCiuAutoSi.AutoSize = true;
            this.rbCiuAutoSi.Checked = true;
            this.rbCiuAutoSi.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCiuAutoSi.Location = new System.Drawing.Point(3, 3);
            this.rbCiuAutoSi.Name = "rbCiuAutoSi";
            this.rbCiuAutoSi.Size = new System.Drawing.Size(36, 19);
            this.rbCiuAutoSi.TabIndex = 17;
            this.rbCiuAutoSi.TabStop = true;
            this.rbCiuAutoSi.Text = "Si";
            this.rbCiuAutoSi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "#Siguiente";
            // 
            // txtCiuNumSig
            // 
            this.txtCiuNumSig.Enabled = false;
            this.txtCiuNumSig.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiuNumSig.Location = new System.Drawing.Point(361, 41);
            this.txtCiuNumSig.MaxLength = 6;
            this.txtCiuNumSig.Name = "txtCiuNumSig";
            this.txtCiuNumSig.Size = new System.Drawing.Size(110, 21);
            this.txtCiuNumSig.TabIndex = 0;
            this.txtCiuNumSig.Text = "1";
            this.txtCiuNumSig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCiuNumSig.TextChanged += new System.EventHandler(this.txtCiuNumSig_TextChanged);
            this.txtCiuNumSig.Enter += new System.EventHandler(this.txtCiuNumSig_Enter);
            // 
            // txtCiuPrefijo
            // 
            this.txtCiuPrefijo.Enabled = false;
            this.txtCiuPrefijo.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiuPrefijo.Location = new System.Drawing.Point(135, 41);
            this.txtCiuPrefijo.MaxLength = 4;
            this.txtCiuPrefijo.Name = "txtCiuPrefijo";
            this.txtCiuPrefijo.Size = new System.Drawing.Size(64, 21);
            this.txtCiuPrefijo.TabIndex = 27;
            this.txtCiuPrefijo.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Automático";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Prefijos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Documentos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID Ciudades:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnOpParent);
            this.tabPage1.Controls.Add(this.txtParentS);
            this.tabPage1.Controls.Add(this.txtPreParent);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.pnOpZona);
            this.tabPage1.Controls.Add(this.txtZonaNumS);
            this.tabPage1.Controls.Add(this.txtPrefZona);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.pnOpTitel);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtTitelNunS);
            this.tabPage1.Controls.Add(this.txtPrefTitel);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(490, 330);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Tablillas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnOpZona
            // 
            this.pnOpZona.Controls.Add(this.radioButton5);
            this.pnOpZona.Controls.Add(this.radioButton6);
            this.pnOpZona.Enabled = false;
            this.pnOpZona.Location = new System.Drawing.Point(241, 74);
            this.pnOpZona.Name = "pnOpZona";
            this.pnOpZona.Size = new System.Drawing.Size(99, 29);
            this.pnOpZona.TabIndex = 42;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(43, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(40, 19);
            this.radioButton5.TabIndex = 18;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "No";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(3, 3);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(36, 19);
            this.radioButton6.TabIndex = 17;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Si";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // txtZonaNumS
            // 
            this.txtZonaNumS.Enabled = false;
            this.txtZonaNumS.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZonaNumS.Location = new System.Drawing.Point(364, 78);
            this.txtZonaNumS.MaxLength = 6;
            this.txtZonaNumS.Name = "txtZonaNumS";
            this.txtZonaNumS.Size = new System.Drawing.Size(110, 21);
            this.txtZonaNumS.TabIndex = 39;
            this.txtZonaNumS.Text = "1";
            this.txtZonaNumS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtZonaNumS.TextChanged += new System.EventHandler(this.txtZonaNumS_TextChanged);
            this.txtZonaNumS.Enter += new System.EventHandler(this.txtZonaNumS_Enter);
            // 
            // txtPrefZona
            // 
            this.txtPrefZona.Enabled = false;
            this.txtPrefZona.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrefZona.Location = new System.Drawing.Point(138, 78);
            this.txtPrefZona.MaxLength = 4;
            this.txtPrefZona.Name = "txtPrefZona";
            this.txtPrefZona.Size = new System.Drawing.Size(64, 21);
            this.txtPrefZona.TabIndex = 41;
            this.txtPrefZona.Text = "N/A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 40;
            this.label12.Text = "ID Zona";
            // 
            // pnOpTitel
            // 
            this.pnOpTitel.Controls.Add(this.radioButton1);
            this.pnOpTitel.Controls.Add(this.radioButton2);
            this.pnOpTitel.Enabled = false;
            this.pnOpTitel.Location = new System.Drawing.Point(241, 39);
            this.pnOpTitel.Name = "pnOpTitel";
            this.pnOpTitel.Size = new System.Drawing.Size(99, 29);
            this.pnOpTitel.TabIndex = 38;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(43, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 19);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "No";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(3, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(36, 19);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Si";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "#Siguiente";
            // 
            // txtTitelNunS
            // 
            this.txtTitelNunS.Enabled = false;
            this.txtTitelNunS.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitelNunS.Location = new System.Drawing.Point(364, 43);
            this.txtTitelNunS.MaxLength = 6;
            this.txtTitelNunS.Name = "txtTitelNunS";
            this.txtTitelNunS.Size = new System.Drawing.Size(110, 21);
            this.txtTitelNunS.TabIndex = 31;
            this.txtTitelNunS.Text = "1";
            this.txtTitelNunS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTitelNunS.TextChanged += new System.EventHandler(this.txtTitelNunS_TextChanged);
            this.txtTitelNunS.Enter += new System.EventHandler(this.txtTitelNunS_Enter);
            // 
            // txtPrefTitel
            // 
            this.txtPrefTitel.Enabled = false;
            this.txtPrefTitel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrefTitel.Location = new System.Drawing.Point(138, 43);
            this.txtPrefTitel.MaxLength = 4;
            this.txtPrefTitel.Name = "txtPrefTitel";
            this.txtPrefTitel.Size = new System.Drawing.Size(64, 21);
            this.txtPrefTitel.TabIndex = 36;
            this.txtPrefTitel.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(245, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "Automático";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(137, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Prefijos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 18);
            this.label10.TabIndex = 33;
            this.label10.Text = "Documentos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 15);
            this.label11.TabIndex = 32;
            this.label11.Text = "ID Tipo Tel.";
            // 
            // pnOpParent
            // 
            this.pnOpParent.Controls.Add(this.radioButton7);
            this.pnOpParent.Controls.Add(this.radioButton8);
            this.pnOpParent.Enabled = false;
            this.pnOpParent.Location = new System.Drawing.Point(241, 109);
            this.pnOpParent.Name = "pnOpParent";
            this.pnOpParent.Size = new System.Drawing.Size(99, 29);
            this.pnOpParent.TabIndex = 46;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(43, 3);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(40, 19);
            this.radioButton7.TabIndex = 18;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "No";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Checked = true;
            this.radioButton8.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(3, 3);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(36, 19);
            this.radioButton8.TabIndex = 17;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Si";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // txtParentS
            // 
            this.txtParentS.Enabled = false;
            this.txtParentS.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentS.Location = new System.Drawing.Point(364, 113);
            this.txtParentS.MaxLength = 6;
            this.txtParentS.Name = "txtParentS";
            this.txtParentS.Size = new System.Drawing.Size(110, 21);
            this.txtParentS.TabIndex = 43;
            this.txtParentS.Text = "1";
            this.txtParentS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtParentS.TextChanged += new System.EventHandler(this.txtParentS_TextChanged);
            this.txtParentS.Enter += new System.EventHandler(this.txtParentS_Enter);
            // 
            // txtPreParent
            // 
            this.txtPreParent.Enabled = false;
            this.txtPreParent.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreParent.Location = new System.Drawing.Point(138, 113);
            this.txtPreParent.MaxLength = 4;
            this.txtPreParent.Name = "txtPreParent";
            this.txtPreParent.Size = new System.Drawing.Size(64, 21);
            this.txtPreParent.TabIndex = 45;
            this.txtPreParent.Text = "N/A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 15);
            this.label13.TabIndex = 44;
            this.label13.Text = "ID Parentezco";
            // 
            // frmNumeracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAtras;
            this.ClientSize = new System.Drawing.Size(525, 420);
            this.ControlBox = false;
            this.Controls.Add(this.tcEnum);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmNumeracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numeraciones";
            this.Load += new System.EventHandler(this.frmNumeracion_Load);
            this.tcEnum.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp1.PerformLayout();
            this.pnOpSector.ResumeLayout(false);
            this.pnOpSector.PerformLayout();
            this.pnOpCiu.ResumeLayout(false);
            this.pnOpCiu.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnOpZona.ResumeLayout(false);
            this.pnOpZona.PerformLayout();
            this.pnOpTitel.ResumeLayout(false);
            this.pnOpTitel.PerformLayout();
            this.pnOpParent.ResumeLayout(false);
            this.pnOpParent.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TabControl tcEnum;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.Panel pnOpSector;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox txtSecNumSig;
        private System.Windows.Forms.TextBox txtPrefijoSec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnOpCiu;
        private System.Windows.Forms.RadioButton rbCiuAutoNo;
        private System.Windows.Forms.RadioButton rbCiuAutoSi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCiuNumSig;
        private System.Windows.Forms.TextBox txtCiuPrefijo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnOpTitel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitelNunS;
        private System.Windows.Forms.TextBox txtPrefTitel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnOpZona;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.TextBox txtZonaNumS;
        private System.Windows.Forms.TextBox txtPrefZona;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnOpParent;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.TextBox txtParentS;
        private System.Windows.Forms.TextBox txtPreParent;
        private System.Windows.Forms.Label label13;
    }
}