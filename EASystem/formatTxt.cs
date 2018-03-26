using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASystem
{
    class FormatTxt
    {
        public static void ControladorKeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (e.KeyData == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }

        }
        public static void formatCedula(object sender,EventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            if (ctrl.Text != "")
            {
                string cad = ctrl.Text.Replace("-", "");
                long value = Convert.ToInt64(cad);
                ctrl.Text = value.ToString("000-#######-#");
            }
        }

        public static void formatTel(object sender, EventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            if (ctrl.Text != "")
            {
                if (ctrl.Text.Length < 10)
                {
                    MessageBox.Show("¡Número de Teléfono invalido!", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ctrl.Focus();
                    ctrl.SelectAll();
                }
                else
                {
                    string cad = ctrl.Text.Replace("-", "");
                    long value = Convert.ToInt64(cad);
                    ctrl.Text = value.ToString("000-000-0000");
                }
            }
        }

        public static void formatDecPorcentaje(object sender, EventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            if (ctrl.Text != "")
            {
                if (ctrl.Text.Contains("."))
                {
                    string[] cad = ctrl.Text.Split('.');
                    long value1 = Convert.ToInt64(cad[0]);
                    if (cad[1].Length < 2 || cad[1].Length==0)
                    {
                        cad[1] = cad[1] + "0";
                        long value2 = Convert.ToInt64(cad[1]);
                        ctrl.Text = value1.ToString("##") + "." + value2.ToString("00");
                    }
                    else
                    {
                        long value2 = Convert.ToInt64(cad[1]);
                        ctrl.Text = value1.ToString("##") + "." + value2.ToString("##");
                    }   
                }
                else
                {
                    long value = Convert.ToInt64(ctrl.Text);
                    ctrl.Text = value.ToString("##.00");
                }
                
            }
        }
    }
}
