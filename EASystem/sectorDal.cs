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
    class sectorDal
    {
        public static int addSector(sector pSector)
        {
            int retorno = 0;
            MySqlConnection conexion = Conectando.conectando();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.CommandText = "insertSector";

                    cmd.Parameters.AddWithValue("pIdCiu", pSector.idCiu);
                    cmd.Parameters.AddWithValue("pNomSec", pSector.nomSector);

                    retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "ERROR AL INSERTAR EL REGISTRO");
                }
                finally
                {
                    conexion.Close();
                }
            }
            return retorno;
        }

        public static List<sector> buscar(string filtroCiudad)
        {
            List<sector> _lista = new List<sector>();
            MySqlCommand _comando = new MySqlCommand(string.Format(
                "SELECT idsector, nomsector FROM sector where idciudad="+filtroCiudad), Conectando.conectando());
            try
            {
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    sector pSector = new sector();
                    pSector.id = _reader.GetInt32(0);
                    //pSector.idCiu = _reader.GetInt32(1);
                    pSector.nomSector = _reader.GetString(1);

                    _lista.Add(pSector);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR AL BUSCAR REGISTRO");
            }
            

            return _lista;
        }

        public static sector ObtenerSec(int pId)
        {
            sector pSector = new sector();

            MySqlConnection conexion = Conectando.conectando();
            MySqlCommand _comando = new MySqlCommand(string.Format(
                "SELECT idsector, idciudad, nomsector FROM sector where idsector={0}", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pSector.id = _reader.GetInt32(0);
                pSector.idCiu = _reader.GetInt32(1);
                pSector.nomSector = _reader.GetString(2);
            }
            conexion.Close();
            return pSector;
        }

        public static int updSector(sector pSector)
        {
            int retorno = 0;
            MySqlConnection conexion = Conectando.conectando();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.CommandText = "updateSector";

                    cmd.Parameters.AddWithValue("pId", pSector.id);
                    cmd.Parameters.AddWithValue("pIdCiu", pSector.idCiu);
                    cmd.Parameters.AddWithValue("pNomSec", pSector.nomSector);

                    retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "Error en actualizar el registro");
                }
                finally
                {
                    conexion.Close();
                }
            }

            return retorno;
        }

        public static int delSector(sector pSector)
        {
            int retorno = 0;
            MySqlConnection conexion = Conectando.conectando();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    cmd.CommandText = "delsector";

                    cmd.Parameters.AddWithValue("pId", pSector.id);
                    cmd.Parameters.AddWithValue("pIdC", pSector.idCiu);

                    retorno = cmd.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "ERROR AL ELIMINAR REGISTRO SECTOR");
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
