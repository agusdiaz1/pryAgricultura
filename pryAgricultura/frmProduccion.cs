using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAgricultura
{
    public partial class frmProduccion : Form
    {
        conexionBD conexion = new conexionBD();
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {

        }

        public void CargarLocalidades()
        {
            cboLocalidad.Items.Clear();
            List<string> listaLocalidad = conexion.ObtenerLocalidades();

            foreach (var loc in listaLocalidad)
            {
                cboLocalidad.Items.Add(loc);
            }
        }
    }
}
