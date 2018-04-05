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
    public partial class frmClientes : Form
    {
        private frmPrincipal mfrm;
        public frmClientes(frmPrincipal mform)
        {
            InitializeComponent();
            mfrm = mform;
            rNew();
            ctrlInicio(false);
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            //string[] colecc = new string[2] { "nombre ", "direeccio" };
            listView1.Items.Add(new ListViewItem(new string[] { "Casa", "809-576-2357" }));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem listItem = listView1.SelectedItems[0];

                txtNombre.Text = listItem.Text;
                txtApellido.Text = listItem.SubItems[1].Text;
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

        private void ctrlInicio(Boolean verdad)
        {

            btnModificar.Enabled = verdad;
            btnEliminar.Enabled = verdad;
            btnSalvar.Enabled = verdad;

           
        }
        
    

        private void rNew()
        {
            //cargar comboboxs
            fillcbCiu();
            fillCbSec();
            fillCbTiTel();
            fillCbParent();
            cbCivil.SelectedIndex = 0;
            //limpiar los txt 
            txtCed.Clear();
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtDir.Clear();
            txtTel.Clear();
            txtLimCre.Clear();
            txtNombreCon.Clear();
            txtCedCon.Clear();
            txtTelCon.Clear();
            txtNomPariente.Clear();
            txtApePariente.Clear();
            txtTelPariente.Clear();
            txtNomEmp.Clear();
            txtTelEmp.Clear();
            txtSalario.Clear();
            txtCedGar.Clear();
            txtPuestoGar.Clear();
            txtSalGar.Clear();
            txtEmpGar.Clear();
            txtCobrador.Clear();
            txtZona.Clear();

            //limpiar listviews
            listView1.Items.Clear();

            //dataTimerPickup
            dtpFecNac.ResetText();
            dtpFechaIn.ResetText();
            dtpFecInGar.ResetText();

            dtvParent.AllowUserToAddRows = false;
            dtvParent.Rows.Clear();

            tabControl1.SelectedIndex = 0;
            txtCed.Focus();
        }

        private void fillcbCiu()
        {
            cbCiudad.DisplayMember = "nomciudad";
            cbCiudad.ValueMember = "idciudad";
            cbCiudad.DataSource = fillControles.fillCbox("ciudad", "nomciudad");
        }

        private void fillCbSec()
        {
            cbSector.DataSource = null;
            cbSector.DisplayMember = "nomsector";
            cbSector.ValueMember = "idsector";
            cbSector.DataSource = fillControles.fillCbox("sector", "idciudad", cbCiudad.SelectedValue.ToString());
        }

        private void fillCbTiTel()
        {
            cbTiTel.DataSource = null;
            cbTiTel.DisplayMember = "nomtitel";
            cbTiTel.ValueMember = "id";
            cbTiTel.DataSource = fillControles.fillCbox("tipotel", "id");
        }

        private void fillCbParent()
        {
            cbParentezco.DataSource = null;
            cbParentezco.DisplayMember = "parentezco";
            cbParentezco.ValueMember = "id";
            cbParentezco.DataSource = fillControles.fillCbox("parentezco", "id");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCbSec();
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }else if (Char.IsSeparator(e.KeyChar))
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
            
            //txtTel.Text = txtTel.Text.Replace(" ", "");
            //
        }

        private void txtTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void soloNum(object sender, KeyPressEventArgs e)
        {
            formatTxt.valNumeric(sender, e);
        }

        private void btnAddTel_Click(object sender, EventArgs e)
        {
            if (txtTel.Text != "")
            {
                //string pid = cbTiTel.SelectedValue.ToString();
                listView1.Items.Add(new ListViewItem(new string[] { tiTelDala.findOne(cbTiTel.SelectedValue.ToString()), txtTel.Text }));
                txtTel.Clear();
                txtTel.Focus();
            }
        }

        private void btnAddPariente_Click(object sender, EventArgs e)
        {
            Tipos pObjet = new Tipos();
            if(txtNomPariente.Text!="" && txtApePariente.Text!="" && txtTelPariente.Text != "")
            {
                pObjet = parentDal.obtenerReg(int.Parse(cbParentezco.SelectedValue.ToString()));
                dtvParent.Rows.Add(txtNomPariente.Text, txtApePariente.Text, txtTelPariente.Text, pObjet.nom);
                txtNomPariente.Clear();
                txtApePariente.Clear(); txtTelPariente.Clear();
                cbParentezco.SelectedIndex = 0;
            }
            txtNomPariente.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            rNew();
        }

        private void txtTel_Leave(object sender, EventArgs e)
        {
            formatTxt.formatTel(sender, e);
        }

        private void txtCed_Leave(object sender, EventArgs e)
        {
            formatTxt.formatCed(sender, e);
        }

        private void formatCedLeve(object sender, EventArgs e)
        {
            formatTxt.formatCed(sender, e);
        }



        private void btnQuitPar_Click(object sender, EventArgs e)
        {
            if (dtvParent.Rows.Count != 0)
            {
                dtvParent.Rows.Remove(dtvParent.CurrentRow);
                txtNomPariente.Focus();
            }
            else
            {
                txtNomPariente.Focus();
            }
            
        }

        private void txtSelectAll(object sender, EventArgs e)
        {
            formatTxt.txtSelectAll(sender, e);
        }
    }
}
