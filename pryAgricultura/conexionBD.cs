using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAgricultura
{
    public class conexionBD
    {
        private OleDbConnection conexion;
        string cadena;
        public conexionBD()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source= ../../../BD/ControlCamiones.accdb";
            conexion = new OleDbConnection(cadena);
        }

        public DataTable EjecutarConsulta(string consulta)
        {
            DataTable tabla = new DataTable();
            try
            {
                conexion.Open();
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return tabla;
        }



        public void EjecutarComando(string comandoAcc)
        {
            try
            {
                conexion.Open();
                OleDbCommand comando = new OleDbCommand(comandoAcc, conexion);
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ejecutar: "+ ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }


        public List<string> ObtenerLocalidades()
        {
            List<string> localidad = new List<string>();

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    string sql = "SELECT DISTINCT Nombre FROM Localidades";
                    using (OleDbCommand comando = new OleDbCommand(sql, conexion))
                    {
                        conexion.Open();
                        OleDbDataReader lector = comando.ExecuteReader();

                        while (lector.Read())
                        {
                            localidad.Add(lector["Nombre"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las localidades: " + ex.Message);
            }

            return localidad;
        }


        public List<string> ObtenerCultivos()
        {
            List<string> cultivo = new List<string>();

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    string sql = "SELECT DISTINCT Nombre FROM Cultivos";
                    using (OleDbCommand comando = new OleDbCommand(sql, conexion))
                    {
                        conexion.Open();
                        OleDbDataReader lector = comando.ExecuteReader();

                        while (lector.Read())
                        {
                            cultivo.Add(lector["Nombre"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los cultivos: " + ex.Message);
            }

            return cultivo;
        }

        public DataTable ObtenerProduccionPorLocalidad(string nombreLocalidad)
        {
            string sql = @"SELECT C.Nombre AS Cultivo, P.Produccion
                       FROM (Produccion AS P 
                       INNER JOIN Localidades AS L ON P.Localidad = L.Id)
                       INNER JOIN Cultivos AS C ON P.Cultivo = C.Id
                       WHERE L.Nombre = @Localidad";

            DataTable tabla = new DataTable();
            try
            {
                conexion.Open();
                OleDbCommand comando = new OleDbCommand(sql, conexion);
                comando.Parameters.AddWithValue("@Localidad", nombreLocalidad);
                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener producción: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return tabla;
        }

        public DataTable ObtenerProduccionTotal()
        {
            string sql = @"SELECT L.Nombre AS Localidad, SUM(P.Produccion) AS TotalProduccion
                       FROM Produccion AS P 
                       INNER JOIN Localidades AS L ON P.Localidad = L.Id
                       GROUP BY L.Nombre";

            return EjecutarConsulta(sql);
        }
    }
}
