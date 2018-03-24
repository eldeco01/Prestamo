using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASystem
{
    class zonaDal
    {
        public static List<Tipos> buscar()
        {
            List<Tipos> _lista = new List<Tipos>();
            MySqlCommand _comando = new MySqlCommand(string.Format(
                "SELECT id, nomzona FROM zona"), Conectando.conectando());

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Tipos tipotel = new Tipos();
                tipotel.id = _reader.GetInt32(0);
                tipotel.nom = _reader.GetString(1);

                _lista.Add(tipotel);
            }

            return _lista;
        }

        public static Tipos obtenerReg(int pId)
        {
            Tipos pObjet = new Tipos();
            MySqlConnection conexion = Conectando.conectando();
            try
            {            
                MySqlCommand _comando = new MySqlCommand(string.Format(
                    "SELECT id, nomzona FROM zona where id={0}", pId), conexion);
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    pObjet.id = _reader.GetInt32(0);
                    pObjet.nom = _reader.GetString(1);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "ERROR AL BUSCAR EL REGISTRO ZONA");
            }
            finally
            {
                conexion.Close();
            }
            return pObjet;
        }

        public static int update(Tipos pObjet)
        {
            int retorno = 0;
            MySqlConnection conexion = Conectando.conectando();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.CommandText = "updzona";

                    cmd.Parameters.AddWithValue("pId", pObjet.id);
                    cmd.Parameters.AddWithValue("pNomZona", pObjet.nom);

                    retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "ERROR AL ACTUALIZAR EL REGISTRO ZONA");
                }
                finally
                {
                    conexion.Close();
                }
            }

            return retorno;
        }

        public static int insertar(Tipos pObjet)
        {
            int retorno = 0;
            MySqlConnection conexion = Conectando.conectando();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.CommandText = "inZona";

                    cmd.Parameters.AddWithValue("pZona", pObjet.nom);

                    retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "ERROR AL INSERTAR EL REGISTRO ZONA");
                }
                finally
                {
                    conexion.Close();
                }
            }
            return retorno;
        }

        public static int delete(Tipos pObjet)
        {
            int retorno = 0;
            MySqlConnection conexion = Conectando.conectando();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.CommandText = "delZona";

                    cmd.Parameters.AddWithValue("pId", pObjet.id);

                    retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "ERROR AL ELIMINAR EL REGISTRO ZONA");
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
