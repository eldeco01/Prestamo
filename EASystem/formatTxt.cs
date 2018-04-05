using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASystem
{
    class formatTxt
    {
        public static void valNumeric(object sender, KeyPressEventArgs e)
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

        public static void formatTel(object sender, EventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            if (ctrl.Text !="")
            {
                if(ctrl.Text.Length < 11 && ctrl.Text.Length>9)
                {
                    long value = Convert.ToInt64(ctrl.Text);
                    ctrl.Text = value.ToString("###-###-####");
                }
                else if (ctrl.Text.Contains("-"))
                {
                    string cad = ctrl.Text.Replace("-", "");
                    long value = Convert.ToInt64(cad);
                    ctrl.Text = value.ToString("###-###-####");
                }
                else
                {
                    MessageBox.Show("Favor solo introducir números sin guiones", "Télefono incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ctrl.Focus();
                    ctrl.SelectAll();
                }

            }
        }

        public static void formatCed(object sender, EventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            if (ctrl.Text != "")
            {
                if (ctrl.Text.Length < 12 && ctrl.Text.Length > 10)
                {
                    long value = Convert.ToInt64(ctrl.Text);
                    ctrl.Text = value.ToString("00#-#######-#");
                }
                else if (ctrl.Text.Contains("-"))
                {
                    string cad = ctrl.Text.Replace("-", "");
                    long value = Convert.ToInt64(cad);
                    ctrl.Text = value.ToString("00#-#######-#");
                }
                else
                {
                    MessageBox.Show("Favor solo introducir números sin guiones", "Cédula incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ctrl.Focus();
                    ctrl.SelectAll();
                }
            }
        }

        public static void txtSelectAll(object sender, EventArgs e)//con el evento enter
        {
            TextBox ctrl = sender as TextBox;
            ctrl.SelectAll();
        }
    }
}
