using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASystem
{
    class enumDal
    {
        public static int updNumSig3(int pNextNum,string peCampo)
        {
            int retorno = 0;
            MySqlConnection conexion = Conectando.conectando();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.CommandText = "updEnum3";

                    cmd.Parameters.AddWithValue("pCampo", peCampo);
                    cmd.Parameters.AddWithValue("pValor", pNextNum);

                    retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
                finally
                {
                    conexion.Close();
                }
            }

            return retorno;
        }
    }
}
