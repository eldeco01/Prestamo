using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASystem
{
    public class nextNum
    {
        public static int buscar(string pCampo)//pCampo se refiere al campo a buscar 
        {
            int numNext = 0;
            MySqlConnection conexion = Conectando.conectando();
            string pString = "SELECT " + pCampo + " FROM enum WHERE id='1'";
            MySqlCommand _comando = new MySqlCommand(string.Format(pString), conexion);
            try
            {
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    numNext = _reader.GetInt32(0);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error en la Numeración Buscada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            conexion.Close();
            return numNext+1;
        }
    }
}
