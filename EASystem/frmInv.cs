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
    public partial class frmInv : Form
    {
        private frmPrincipal1 mfrm;
        public frmInv(frmPrincipal1 mform)
        {
            InitializeComponent();
            mfrm = mform;
        }

        private void frmInv_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
