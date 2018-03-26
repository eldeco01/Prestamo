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
	public partial class frmSector : Form
	{
		private frmPrincipal mfrm;
        private string indexCiud;
        private Boolean modSalvar = false;
        public frmSector(frmPrincipal mform)
		{
			InitializeComponent();
			mfrm = mform;
            //ctrlInicio(false);
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
            sector pSector = new sector();
            pSector.id = int.Parse(txtIdSec.Text.Trim());
            pSector.idCiu = int.Parse(cbCiudad.SelectedValue.ToString());
            pSector.nomSector = txtNomSector.Text.Trim();
            int updResul = sectorDal.updSector(pSector);
            if (updResul > 0)
            {
                MessageBox.Show("Ciudad Modificado con exito!!", "Modificando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rNew();
            }
            else
            {
                int resultado = sectorDal.addSector(pSector);
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
            cbCiudad.Enabled = !verdad;
            btnModificar.Enabled = verdad;
            btnEliminar.Enabled = verdad;
            btnSalvar.Enabled = verdad;

            modSalvar = !verdad;
        }

        private void rNew()
        {
            txtIdSec.Text = nextNum.buscar("numsector").ToString();
            //lblEstado.BackColor = Control;
            lblEstado.Text = "<<<Nuevo>>>";
            lblEstado.ForeColor= Color.FromArgb(0, 192, 0);
            txtIdSec.Enabled = false;
            txtNomSector.Clear();
            txtNomSector.Enabled = true;
            ctrlInicio(false);
            txtNomSector.Focus();
            
            cbCiudad.DisplayMember = "nomciudad";
            cbCiudad.ValueMember = "idciudad";
            cbCiudad.DataSource = fillControles.fillCbox("ciudad", "nomciudad");
            cargarDgv();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNomSector.Text != "")
            {
                ctrlInicio(true);
            }
            else
            {
                ctrlInicio(false);
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            rNew();
        }

        private void cargarDgv()
        {
            
            dgvSector.Columns[0].DataPropertyName = "id";
            dgvSector.Columns[1].DataPropertyName = "idCiu";
            dgvSector.Columns[2].DataPropertyName = "nomSector";

            dgvSector.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //string test = cbCiudad.SelectedValue.ToString();
            
            dgvSector.DataSource = sectorDal.buscar(indexCiud);
            dgvSector.Columns[0].Width = 40;
            dgvSector.Columns[2].Width = 257;
            dgvSector.Columns[1].Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "<<<Modificando>>>";
            lblEstado.ForeColor = Color.FromArgb(255,0,0);
            txtNomSector.Enabled = true;
            txtNomSector.Focus();txtNomSector.SelectAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que desea ELIMINAR el registro?", "¿Eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lblEstado.Text = "<<<ELIMINANDO>>>";
                lblEstado.ForeColor = Color.FromArgb(255, 255, 255);
                
                sector pSector = new sector();
                pSector.id = int.Parse(txtIdSec.Text.Trim());
                pSector.idCiu = int.Parse(cbCiudad.SelectedValue.ToString());
                pSector.nomSector = txtNomSector.Text.Trim();
                int delResul = sectorDal.delSector(pSector);
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCiudadA);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmCiudadA(mfrm);
                frm.MdiParent = mfrm;
                frm.Show();
            }
        }

        private void btnModificar_MouseEnter(object sender, EventArgs e)
        {
            btnModificar.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.BackColor = Color.FromArgb(255, 250, 205);
        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            btnNuevo.BackColor = Color.FromArgb(255, 250, 205);
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.FromArgb(255, 250, 205);
        }

        private void btnSalvar_MouseLeave(object sender, EventArgs e)
        {
            btnSalvar.BackColor = Color.FromArgb(255, 250, 205);
        }

        private void btnAtras_MouseLeave(object sender, EventArgs e)
        {
            btnAtras.BackColor = Color.FromArgb(255, 250, 205);
        }

        private void btnAtras_MouseEnter(object sender, EventArgs e)
        {
            btnAtras.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void btnNuevo_MouseEnter(object sender, EventArgs e)
        {
            btnNuevo.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void btnSalvar_MouseEnter(object sender, EventArgs e)
        {
            btnSalvar.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void frmSector_Load(object sender, EventArgs e)
        {
            
        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

            indexCiud = cbCiudad.SelectedValue.ToString();
            
            cargarDgv();
        }

        private void dgvSector_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sector modSec = new sector();
            modSec = sectorDal.ObtenerSec((int)dgvSector.CurrentRow.Cells["ID"].Value);
            lblEstado.Text = "<<<Consultando>>>";
            lblEstado.ForeColor = Color.FromArgb(65, 105, 225);
            txtIdSec.Text = modSec.id.ToString();
            txtNomSector.Text = modSec.nomSector;
            cbCiudad.SelectedValue = modSec.idCiu;
            ctrlInicio(true);
            txtNomSector.Enabled = false;
        }
    }
}
