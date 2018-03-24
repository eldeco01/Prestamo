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
    public partial class frmPrincipal1 : Form
    {
        public frmPrincipal1()
        {
            InitializeComponent();
            barraMenu();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            barraMenu(pnInv);
            pnContainer.BackColor = Color.FromArgb(212, 226, 239);


        }

        private void barraMenu(Panel activePanel)
        {
            pnInv.Enabled = false; pnInv.Visible = false;
            pnCxc.Enabled = false; pnCxc.Visible = false;
            pnCxp.Enabled = false; pnCxp.Visible = false;
            pnCont.Enabled = false; pnCont.Visible = false;

            activePanel.Enabled = true; activePanel.Visible = true;
        }
        private void barraMenu()
        {
            pnInv.Enabled = false; pnInv.Visible = false;
            pnCxc.Enabled = false; pnCxc.Visible = false;
            pnCxp.Enabled = false; pnCxp.Visible = false;
            pnCont.Enabled = false; pnCont.Visible = false;
        }

        private void btnCxC_Click(object sender, EventArgs e)
        {
            barraMenu(pnCxc);
        }

        private void btnCxp_Click(object sender, EventArgs e)
        {
            barraMenu(pnCxp);
        }

        private void btnMenEntradas_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmInv);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmInv(this);
                frm.MdiParent = this;
                this.pnContainer.Controls.Add(frm);
                //header.Hide();
                frm.Show();
            }
            //subMenuActive(btnCiudades);
        }
    }

}
