using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASystem
{
	public partial class frmCobrador : Form
	{
		private frmPrincipal mfrm;
        private Boolean modSalvar = false;
        public frmCobrador(frmPrincipal mform)
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
            Cobrador pCobrador = new Cobrador();
            pCobrador.id = int.Parse(txtId.Text.Trim());
            pCobrador.nombre = txtNombre.Text.Trim();
            pCobrador.dir = txtDir.Text.Trim();
            pCobrador.tel = txtTel.Text.Trim();
            pCobrador.comision = float.Parse(txtComis.Text);
            int updResul = CobradorDal.update(pCobrador);
            if (updResul > 0)
            {
                MessageBox.Show("Cobrador Modificado con exito!!", "Modificando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rNew();
            }
            else
            {
                int resultado = CobradorDal.insertar(pCobrador);
                if (resultado > 0)
                {
                    MessageBox.Show("Cobrador Guardada con exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rNew();
                }
                else
                {
                    MessageBox.Show("No se pudo guardad el registro", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            txtId.Text = nextNum.buscar("idcobrador").ToString("000");
           // lblEstado.BackColor = Control;
            lblEstado.Text = "<<<Nuevo>>>";
            lblEstado.ForeColor= Color.FromArgb(0, 192, 0);
            txtId.Enabled = false;
            txtNombre.Clear();
            txtDir.Clear();
            txtTel.Clear();
            txtComis.Clear();
            ctrlInicio(false);
            txtNombre.Focus();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ctrlInicio(true); 
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            rNew();
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
                
                Cobrador objCobrador = new Cobrador();
                objCobrador.id = int.Parse(txtId.Text.Trim());
                int delResul = CobradorDal.delete(objCobrador);
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

        bool Punto = true;
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46 && e.KeyChar != (char)Keys.M)
                e.Handled = true;
            else if (e.KeyChar == 46)
            {
                if (Punto)
                    Punto = false;
                else e.Handled = true;
            }
        }

        private void txtSelectAll(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            Punto = true;
            tb.SelectAll();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            FormatTxt.formatTel(sender,e);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            FormatTxt.ControladorKeyDown(sender, e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            FormatTxt.formatDecPorcentaje(sender, e);
        }

        private void txtTel_Enter(object sender, EventArgs e)
        {
            txtTel.SelectAll();
        }
    }


}
