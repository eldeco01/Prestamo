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
	public partial class frmParent : Form
	{
		private frmPrincipal mfrm;
        private Boolean modSalvar = false;
        public frmParent(frmPrincipal mform)
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
            Tipos pObjet = new Tipos();
            pObjet.id = int.Parse(txtId.Text.Trim());
            pObjet.nom = txtNombre.Text.Trim();
            int updResul = parentDal.update(pObjet);
            if (updResul > 0)
            {
                MessageBox.Show("Zona Modificada con exito!!", "Modificando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rNew();
            }
            else
            {
                int resultado = parentDal.insertar(pObjet);
                if (resultado > 0)
                {
                    MessageBox.Show("Registro Guardado con exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rNew();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Zona", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            txtId.Text = nextNum.buscar("numparent").ToString();
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
            
            dgvContenido.Columns[0].DataPropertyName = "id";
            dgvContenido.Columns[1].DataPropertyName = "nom";

            dgvContenido.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvContenido.DataSource = parentDal.buscar();
            dgvContenido.Columns[0].Width = 40;
            dgvContenido.Columns[1].Width = 170;
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
                
                Tipos pObjet = new Tipos();
                pObjet.id = int.Parse(txtId.Text.Trim());
                pObjet.nom = txtNombre.Text.Trim();
                int delResul = parentDal.delete(pObjet);
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

        private void dgvContenido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Tipos obj = new Tipos();
            obj = parentDal.obtenerReg((int)dgvContenido.CurrentRow.Cells["ID"].Value);
            lblEstado.Text = "<<<Consultando>>>";
            lblEstado.ForeColor = Color.FromArgb(65, 105, 225);
            txtId.Text = obj.id.ToString();
            txtNombre.Text = obj.nom.ToString();
            ctrlInicio(true);
            txtNombre.Enabled = false;
        }
    }
}
