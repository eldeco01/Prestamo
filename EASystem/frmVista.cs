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
    public partial class frmVista : Form
    {
        public frmVista()
        {
            InitializeComponent();
        }


        private void cargarDgv()
        {

            dgvBuscar.Columns[0].DataPropertyName = "id";
            dgvBuscar.Columns[1].DataPropertyName = "idCiu";
            dgvBuscar.Columns[2].DataPropertyName = "nomSector";

            dgvBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //string test = cbCiudad.SelectedValue.ToString();

           // dgvBuscar.DataSource = .buscar(indexCiud);
            dgvBuscar.Columns[0].Width = 40;
            dgvBuscar.Columns[2].Width = 257;
            dgvBuscar.Columns[1].Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {



        }
    }
}
