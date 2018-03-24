using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASystem
{
    class tiTelDala
    {
        public static List<Tipos> buscar()
        {
            List<Tipos> _lista = new List<Tipos>();
            MySqlCommand _comando = new MySqlCommand(string.Format(
                "SELECT id, nomTiTel FROM tipotel"), Conectando.conectando());

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

        public static Tipos ObtenerTel(int pId)
        {
            Tipos pTel= new Tipos();
            MySqlConnection conexion = Conectando.conectando();
            try
            {            
                MySqlCommand _comando = new MySqlCommand(string.Format(
                    "SELECT id, nomTiTel FROM tipotel where id={0}", pId), conexion);
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    pTel.id = _reader.GetInt32(0);
                    pTel.nom = _reader.GetString(1);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "ERROR AL INSERTAR EL REGISTRO TIPOTEL");
            }
            finally
            {
                conexion.Close();
            }
            return pTel;
        }

        public static int updTitel(Tipos pTitel)
        {
            int retorno = 0;
            MySqlConnection conexion = Conectando.conectando();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.CommandText = "updTiTel";

                    cmd.Parameters.AddWithValue("pId", pTitel.id);
                    cmd.Parameters.AddWithValue("pTiTel", pTitel.nom);

                    retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "ERROR AL ACTUALIZAR EL REGISTRO TIPOTEL");
                }
                finally
                {
                    conexion.Close();
                }
            }

            return retorno;
        }

        public static int addTitel(Tipos pTitel)
        {
            int retorno = 0;
            MySqlConnection conexion = Conectando.conectando();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.CommandText = "inTiTel";

                    cmd.Parameters.AddWithValue("pTiTel", pTitel.nom);

                    retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "ERROR AL INSERTAR EL REGISTRO TIPOTEL");
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
            string nomTitel = "";
            MySqlConnection conexion = Conectando.conectando();
            try
            {
                MySqlCommand _comando = new MySqlCommand(string.Format(
                    "SELECT nomTiTel FROM tipotel where id="+ id), conexion);
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    
                    nomTitel = _reader.GetString(0);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "ERROR AL INSERTAR EL REGISTRO TIPOTEL");
            }
            finally
            {
                conexion.Close();
            }
            return nomTitel;
        }

    }
}
