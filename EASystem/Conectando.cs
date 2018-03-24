using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASystem
{
    public class Conectando
    {
        public static MySqlConnection conectando()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=easystem; Uid=root; pwd=rootroot");
            try
            {
                conectar.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"NO SE ENCUENTRA LA CONEXION CON EL SERVIDOR");
            }
            return conectar;
        }

       /* public static int nextNum(string tbl, string prt, string compare)
        {

        }*/
    }
}
