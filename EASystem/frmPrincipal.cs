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
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
			timer1.Enabled = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lbTbarHora.Text = DateTime.Now.ToString();
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCiudad);
			if (frm != null)
			{
				frm.BringToFront();
				return;
			}
			else
			{
				frm = new frmCiudad(this);
				frm.MdiParent = this;
				frm.Show();
			}
		}

		private void numeraciónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmNumeracion);
			if (frm != null)
			{
				frm.BringToFront();
				return;
			}
			else
			{
				frm = new frmNumeracion(this);
				frm.MdiParent = this;
				//frm.StartPosition = FormStartPosition.CenterParent;
				//header.Hide();
				frm.Show();
			}
			//subMenuActive(btnCiudades);
		}

        private void sectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmSector);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmSector(this);
                frm.MdiParent = this;
                //frm.StartPosition = FormStartPosition.CenterParent;
                frm.Show();
            }
        }

        private void tipoTelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmTitel);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmTitel(this);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void zonaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmZona);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmZona(this);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void parentezcoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmParent);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmParent(this);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmClientes);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmClientes(this);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void crearPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmPrestamo);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmPrestamo(this);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void cobradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCobrador);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmCobrador(this);
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}

