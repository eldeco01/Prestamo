using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASystem
{
    class parentDal
    {
        public static List<Tipos> buscar()
        {
            List<Tipos> _lista = new List<Tipos>();
            MySqlCommand _comando = new MySqlCommand(string.Format(
                "SELECT id, parentezco FROM parentezco"), Conectando.conectando());

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
                    "SELECT id, parentezco FROM parentezco where id={0}", pId), conexion);
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    pObjet.id = _reader.GetInt32(0);
                    pObjet.nom = _reader.GetString(1);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "ERROR AL BUSCAR EL REGISTRO PARIENTES");
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
                    cmd.CommandText = "updparent";

                    cmd.Parameters.AddWithValue("pId", pObjet.id);
                    cmd.Parameters.AddWithValue("pNom", pObjet.nom);

                    retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "ERROR AL ACTUALIZAR EL REGISTRO PARIENTES");
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
                    cmd.CommandText = "inparent";

                    cmd.Parameters.AddWithValue("pNom", pObjet.nom);

                    retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "ERROR AL INSERTAR EL REGISTRO PARIENTES");
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
                    cmd.CommandText = "delparent";

                    cmd.Parameters.AddWithValue("pId", pObjet.id);

                    retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "ERROR AL ELIMINAR EL REGISTRO PARIENTE");
                }
                finally
                {
                    conexion.Close();
                }
            }

            return retorno;
        }

        public static string findOne(string id)
        {
            string nomParient = "";
            MySqlConnection conexion = Conectando.conectando();
            try
            {
                MySqlCommand _comando = new MySqlCommand(string.Format(
                    "SELECT parentezco FROM parentezco where id=" + id), conexion);
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    nomParient = _reader.GetString(0);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "ERROR AL BUSCAR EL REGISTRO PARENTEZCO");
            }
            finally
            {
                conexion.Close();
            }
            return nomParient;
        }
    }
}
