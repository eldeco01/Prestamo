using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASystem
{
    class CobradorDal
    {
        public static int insertar(Cobrador pCobrador)
        {
            int retorno = 0;
            MySqlConnection conexion = Conectando.conectando();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.CommandText = "insertCobrador";

                    //cmd.Parameters.AddWithValue("pId", pCobrador.id);
                    cmd.Parameters.AddWithValue("pNom", pCobrador.nombre);
                    cmd.Parameters.AddWithValue("pDir", pCobrador.dir);
                    cmd.Parameters.AddWithValue("pTel", pCobrador.tel);
                    cmd.Parameters.AddWithValue("pCom", pCobrador.comision);

                    retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "ERROR AL INSERTAR EL REGISTRO COBRADOR");
                }
                finally
                {
                    conexion.Close();
                }
            }
            return retorno;
        }

        public static List<Cobrador> buscar()
        {
            List<Cobrador> _lista = new List<Cobrador>();
            MySqlCommand _comando = new MySqlCommand(string.Format(
                "SELECT * FROM cobrador"), Conectando.conectando());

            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cobrador obj = new Cobrador();
                obj.id = _reader.GetInt32(0);
                obj.nombre = _reader.GetString(1);
                obj.dir = _reader.GetString(2);
                obj.tel = _reader.GetString(3);
                obj.comision = _reader.GetFloat(4);

                _lista.Add(obj);
            }

            return _lista;
        }

        public static Cobrador ObtenerCobrador(int pId)
        {
            Cobrador obj = new Cobrador();

            MySqlConnection conexion = Conectando.conectando();
            MySqlCommand _comando = new MySqlCommand(string.Format(
                "SELECT * FROM cobrador where id={0}", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                obj.id = _reader.GetInt32(0);
                obj.nombre = _reader.GetString(1);
                obj.dir = _reader.GetString(2);
                obj.tel = _reader.GetString(3);
                obj.comision = _reader.GetFloat(4);
            }
            conexion.Close();
            return obj;
        }

        public static int update(Cobrador pCobrador)
        {
            int retorno = 0;
            MySqlConnection conexion = Conectando.conectando();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.CommandText = "updCobrador";

                    cmd.Parameters.AddWithValue("pId", pCobrador.id);
                    cmd.Parameters.AddWithValue("pNom", pCobrador.nombre);
                    cmd.Parameters.AddWithValue("pDir", pCobrador.dir);
                    cmd.Parameters.AddWithValue("pTel", pCobrador.tel);
                    cmd.Parameters.AddWithValue("pCom", pCobrador.comision);

                    retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "ERROR AL ACTUALIZAR EL REGISTRO COBRADOR");
                }
                finally
                {
                    conexion.Close();
                }
            }

            return retorno;
        }

        public static int delete(Cobrador objCobrador)
        {
            int retorno = 0;
            MySqlConnection conexion = Conectando.conectando();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.CommandText = "delCobrador";

                    cmd.Parameters.AddWithValue("pId", objCobrador.id);

                    retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "ERROR AL BORRAR EL REGISTRO COBRADOR");
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
