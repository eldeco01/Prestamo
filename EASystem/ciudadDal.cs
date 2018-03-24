using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASystem
{
    class ciudadDal
    {
        public static int addCiudad(ciudad pCiudad)
        {
            int retorno = 0;
            MySqlConnection conexion = Conectando.conectando();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.CommandText = "insertCiudad";

                    cmd.Parameters.AddWithValue("pNomC", pCiudad.nomCiu);

                    retorno = cmd.ExecuteNonQuery();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "ERROR AL INSERTAR EL REGISTRO CIUDAD");
                }
                finally
                {
                    conexion.Close();
                }
            }
            return retorno;
        }

        public static List<ciudad> buscar()
        {
            List<ciudad> _lista = new List<ciudad>();
            MySqlCommand _comando = new MySqlCommand(string.Format(
                "SELECT idCiudad, nomCiudad FROM ciudad"), Conectando.conectando());

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ciudad pCiudad = new ciudad();
                pCiudad.id = _reader.GetInt32(0);
                pCiudad.nomCiu = _reader.GetString(1);

                _lista.Add(pCiudad);
            }

            return _lista;
        }

        public static ciudad ObtenerCiudad(int pId)
        {
            ciudad pCiudad = new ciudad();

            MySqlConnection conexion = Conectando.conectando();
            MySqlCommand _comando = new MySqlCommand(string.Format(
                "SELECT idCiudad, nomCiudad FROM ciudad where idciudad={0}",pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pCiudad.id = _reader.GetInt32(0);
                pCiudad.nomCiu = _reader.GetString(1);
            }
            conexion.Close();
            return pCiudad;
        }

        public static int updCiudad(ciudad pCiudad)
        {
            int retorno = 0;
            MySqlConnection conexion = Conectando.conectando();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.CommandText = "updateCiudad";

                    cmd.Parameters.AddWithValue("pId",pCiudad.id);
                    cmd.Parameters.AddWithValue("pNomC", pCiudad.nomCiu);

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

        public static int delCiudad(ciudad pCiudad)
        {
            int retorno = 0;
            MySqlConnection conexion = Conectando.conectando();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.CommandText = "delCiudad";

                    cmd.Parameters.AddWithValue("pId", pCiudad.id);

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
