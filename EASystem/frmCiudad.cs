using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASystem
{
	public partial class frmCiudad : Form
	{
		private frmPrincipal mfrm;
        private Boolean modSalvar = false;
        public frmCiudad(frmPrincipal mform)
		{
			InitializeComponent();
			mfrm = mform;
            ctrlInicio(false);
            rNew();
            
			
		}

		private void btnAtras_Click(object sender, EventArgs e)
		{
            if (modSalvar == true)
            {
                this.Close();
            }
            else
            {
                if (MessageBox.Show("No se ha guardado la modificación, ¿Seguro que desea Salir?", "¡Advertencia!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ciudad pCiudad = new ciudad();
            pCiudad.id = int.Parse(txtId.Text.Trim());
            pCiudad.nomCiu = txtNombre.Text.Trim();
            int updResul = ciudadDal.updCiudad(pCiudad);
            if (updResul > 0)
            {
                MessageBox.Show("Ciudad Modificado con exito!!", "Modificando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rNew();
            }
            else
            {
                int resultado = ciudadDal.addCiudad(pCiudad);
                if (resultado > 0)
                {
                    MessageBox.Show("Ciudad Guardada con exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rNew();
                }
                else
                {
                    MessageBox.Show("No se pudo guardad la Ciudad", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } 
        }

        private void ctrlInicio(Boolean verdad)
        {
            //btnNuevo.Enabled = !verdad;
            btnModificar.Enabled = verdad;
            btnEliminar.Enabled = verdad;
            btnSalvar.Enabled = verdad;

            modSalvar = !verdad;
        }

        private void rNew()
        {
            txtId.Text = nextNum.buscar("numciud").ToString();
           // lblEstado.BackColor = Control;
            lblEstado.Text = "<<<Nuevo>>>";
            lblEstado.ForeColor= Color.FromArgb(0, 192, 0);
            txtId.Enabled = false;
            txtNombre.Clear();
            ctrlInicio(false);
            txtNombre.Focus();
            cargarDgv();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ctrlInicio(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            rNew();
        }

        private void cargarDgv()
        {
            
            dgvCiudad.Columns[0].DataPropertyName = "id";
            dgvCiudad.Columns[1].DataPropertyName = "nomCiu";

            dgvCiudad.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvCiudad.DataSource = ciudadDal.buscar();
            dgvCiudad.Columns[0].Width = 40;
            dgvCiudad.Columns[1].Width = 257;
        }

        private void dgvCiudad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ciudad modCiu = new ciudad();
            modCiu = ciudadDal.ObtenerCiudad((int)dgvCiudad.CurrentRow.Cells["ID"].Value);
            lblEstado.Text = "<<<Consultando>>>";
            lblEstado.ForeColor = Color.FromArgb(65, 105, 225);
            txtId.Text = modCiu.id.ToString();
            txtNombre.Text = modCiu.nomCiu.ToString();
            ctrlInicio(true);
            txtNombre.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "<<<Modificando>>>";
            lblEstado.ForeColor = Color.FromArgb(255,0,0);
            txtNombre.Enabled = true;
            txtNombre.Focus();txtNombre.SelectAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que desea ELIMINAR el registro?", "¿Eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lblEstado.Text = "<<<ELIMINANDO>>>";
                lblEstado.ForeColor = Color.FromArgb(255, 255, 255);
                
                ciudad pCiudad = new ciudad();
                pCiudad.id = int.Parse(txtId.Text.Trim());
                pCiudad.nomCiu = txtNombre.Text.Trim();
                int delResul = ciudadDal.delCiudad(pCiudad);
                if (delResul > 0)
                {
                    MessageBox.Show("¡Registro ELIMINADO con exito!", "¡Eliminando!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rNew();
                }
                else
                {
                    MessageBox.Show("¡Registro no fue encontrado!", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                rNew();
            }
            
        }

        private void frmCiudadA_Load(object sender, EventArgs e)
        {

        }
    }
}
