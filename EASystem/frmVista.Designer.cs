namespace EASystem
{
    partial class frmVista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtvBuscar = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pComi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvBuscar
            // 
            this.dtvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvBuscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cApe,
            this.pTel,
            this.pDir,
            this.pComi});
            this.dtvBuscar.EnableHeadersVisualStyles = false;
            this.dtvBuscar.GridColor = System.Drawing.SystemColors.Control;
            this.dtvBuscar.Location = new System.Drawing.Point(0, 47);
            this.dtvBuscar.Name = "dtvBuscar";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvBuscar.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvBuscar.RowHeadersVisible = false;
            this.dtvBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvBuscar.Size = new System.Drawing.Size(453, 146);
            this.dtvBuscar.TabIndex = 33;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(0, 12);
            this.txtBuscar.MinimumSize = new System.Drawing.Size(0, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(265, 20);
            this.txtBuscar.TabIndex = 34;
            // 
            // cID
            // 
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.Width = 50;
            // 
            // cApe
            // 
            this.cApe.HeaderText = "Nombre";
            this.cApe.Name = "cApe";
            this.cApe.Width = 300;
            // 
            // pTel
            // 
            this.pTel.HeaderText = "Teléfono";
            this.pTel.Name = "pTel";
            // 
            // pDir
            // 
            this.pDir.HeaderText = "Dirección";
            this.pDir.Name = "pDir";
            this.pDir.Visible = false;
            // 
            // pComi
            // 
            this.pComi.HeaderText = "Comisión";
            this.pComi.Name = "pComi";
            this.pComi.Visible = false;
            // 
            // frmVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 255);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dtvBuscar);
            this.Name = "frmVista";
            this.Text = "frmVista";
            ((System.ComponentModel.ISupportInitialize)(this.dtvBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApe;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn pComi;
    }
}