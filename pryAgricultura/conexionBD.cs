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

        public conexionBD()
        {
            string cadena = "Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source= ../../../BD/ControlCamiones.accdb";
            conexion = new OleDbConnection(cadena);
        }

        public DataTable(string consulta)
        {
            DataTable tabla = new DataTable();
            try
            {
                conexion.Open();
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos" + ex.Message);
            }
            
        }
    }
}
