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
	public partial class frmNumeracion : Form
	{
		private frmPrincipal mfrm;
        private Boolean modSalvar = false;
        private static int cantPtoMod = 5;
        private Numeracion[] toModFi = new Numeracion[cantPtoMod];
       // private string[] campoModif = new string[2];
        //private int[] textModificado = new int[2];
		public frmNumeracion(frmPrincipal mform)
		{
			InitializeComponent();
			mfrm = mform;
            ctrlInicio(false);
            valoresIniciales();
            
		}

		private void btnAtras_Click(object sender, EventArgs e)
		{
            if (modSalvar == true){
                this.Close();
            }else{
                if (MessageBox.Show("No se ha guardado la modificación, ¿Seguro que desea Salir?", "¡Advertencia!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
		}

		private void frmNumeracion_Load(object sender, EventArgs e)
		{

		}
        private void ctrlInicio(Boolean verdad)
        {
            //cuadros de textos
            txtCiuPrefijo.Enabled = verdad;
            txtCiuNumSig.Enabled = verdad;
            txtPrefijoSec.Enabled = verdad;
            txtSecNumSig.Enabled = verdad;

            //paneles de opciones
            pnOpSector.Enabled = verdad;
            pnOpCiu.Enabled = verdad;

            //pagina dos
            txtTitelNunS.Enabled = verdad;
            txtPrefTitel.Enabled = verdad;
            pnOpTitel.Enabled = verdad;

            txtZonaNumS.Enabled = verdad;
            txtPrefZona.Enabled = verdad;
            pnOpZona.Enabled = verdad;

            txtParentS.Enabled = verdad;
            txtPrefijoSec.Enabled = verdad;
            pnOpParent.Enabled = verdad;

            //botones
            btnSalvar.Enabled = verdad;
            btnModificar.Enabled = !verdad;

            modSalvar = !verdad;

            //focus
            txtCiuNumSig.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {   
            ctrlInicio(true);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            saveChange(toModFi);
            ctrlInicio(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conectando.conectando();
            MessageBox.Show("Conectado");
        }

        private void valoresIniciales()
        {
            txtCiuNumSig.Text = nextNum.buscar("numciud").ToString();
            txtSecNumSig.Text = nextNum.buscar("numsector").ToString();
            txtTitelNunS.Text = nextNum.buscar("titel").ToString();
            txtZonaNumS.Text = nextNum.buscar("zona").ToString();
            txtParentS.Text = nextNum.buscar("numparent").ToString();
        }

        private void txtCiuNumSig_TextChanged(object sender, EventArgs e)
        {
            toModFi[0] = new Numeracion();
            toModFi[0].modSiNo = true;
            toModFi[0].nomCampo = "numciud";
            toModFi[0].valEnum = (int.Parse(txtCiuNumSig.Text.Trim()));
        }

        private void txtSecNumSig_TextChanged(object sender, EventArgs e)
        {
            toModFi[1] = new Numeracion();
            toModFi[1].modSiNo = true;
            toModFi[1].nomCampo = "numsector";
            toModFi[1].valEnum = (int.Parse(txtSecNumSig.Text.Trim()));

        }
        
        public void saveChange(Numeracion[] estDDatos)
        {
            for (int i = 0; i < cantPtoMod; i++)
            {
                if (estDDatos[i].modSiNo == true)
                {
                    enumDal.updNumSig3(estDDatos[i].valEnum-1, estDDatos[i].nomCampo);
                }
            }
        }

        private void txtSecNumSig_Enter(object sender, EventArgs e)
        {
            txtSecNumSig.SelectAll();
        }

        private void txtCiuNumSig_Enter(object sender, EventArgs e)
        {
            txtCiuNumSig.SelectAll();
        }

        private void txtTitelNunS_TextChanged(object sender, EventArgs e)
        {
            toModFi[2] = new Numeracion();
            toModFi[2].modSiNo = true;
            toModFi[2].nomCampo = "titel";
            toModFi[2].valEnum = (int.Parse(txtTitelNunS.Text.Trim()));
        }

        private void txtTitelNunS_Enter(object sender, EventArgs e)
        {
            txtTitelNunS.SelectAll();
        }

        private void txtZonaNumS_TextChanged(object sender, EventArgs e)
        {
            toModFi[3] = new Numeracion();
            toModFi[3].modSiNo = true;
            toModFi[3].nomCampo = "zona";
            toModFi[3].valEnum = (int.Parse(txtZonaNumS.Text.Trim()));
        }

        private void txtZonaNumS_Enter(object sender, EventArgs e)
        {
            txtZonaNumS.SelectAll();
        }

        private void txtParentS_TextChanged(object sender, EventArgs e)
        {
            toModFi[4] = new Numeracion();
            toModFi[4].modSiNo = true;
            toModFi[4].nomCampo = "numparent";
            toModFi[4].valEnum = (int.Parse(txtParentS.Text.Trim()));
        }

        private void txtParentS_Enter(object sender, EventArgs e)
        {
            txtParentS.SelectAll();
        }
    }
}
