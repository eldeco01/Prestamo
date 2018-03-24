using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASystem
{
    class fillControles
    {
        public static DataTable fillCbox(string pTable, string pCampo1)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM " + pTable;
            MySqlCommand _comando = new MySqlCommand(sql, Conectando.conectando());
            try
            {
                MySqlDataAdapter _adap = new MySqlDataAdapter(_comando);
                _adap.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error en ejecutar el comando");
            }
            return dt;
        }

        public static DataTable fillCbox(string pTable, string pCampo1, string pWhere)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM "+pTable+" WHERE "+pCampo1+"="+pWhere+"";
            MySqlCommand _comando = new MySqlCommand(sql, Conectando.conectando());
            try
            {
                MySqlDataAdapter _adap = new MySqlDataAdapter(_comando);
                _adap.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error en ejecutar el comando");
            }
            return dt;
        }
    }
}
