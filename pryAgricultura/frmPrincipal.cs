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
    public partial class frmPrincipal : Form
    {
        conexionBD conexion = new conexionBD();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            frmProduccion frm = new frmProduccion();
            frm.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void Cargar()
        {
            cboLocalidad.Items.Clear();
            List<string> listaLocalidad = conexion.ObtenerLocalidades();

            foreach (var loc in listaLocalidad)
            {
                cboLocalidad.Items.Add(loc);
            }

            lstCultivo.Items.Clear();
            List<string> listaCultivos = conexion.ObtenerCultivos();

            foreach (var cul in listaCultivos)
            {
                lstCultivo.Items.Add(cul);
            }
        }
    }
}
