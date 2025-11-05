using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            CargarLocalidades();
        }

        private void CargarLocalidades()
        {
            cboLocalidad.Items.Clear();
            foreach (string loc in conexion.ObtenerLocalidades())
            {
                cboLocalidad.Items.Add(loc);
            }
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (cboLocalidad.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una localidad para graficar.");
                return;
            }

            string localidadSeleccionada = cboLocalidad.SelectedItem.ToString();

            DataTable tablaLocalidad = conexion.ObtenerProduccionPorLocalidad(localidadSeleccionada);
            chtLocalidad.Series.Clear();
            chtLocalidad.Titles.Clear();
            chtLocalidad.Titles.Add("Producción por cultivo - " + localidadSeleccionada);

            Series serieLocalidad = new Series("Producción (toneladas)");
            serieLocalidad.ChartType = SeriesChartType.Column;

            foreach (DataRow fila in tablaLocalidad.Rows)
            {
                serieLocalidad.Points.AddXY(fila["Cultivo"].ToString(), Convert.ToInt32(fila["Produccion"]));
            }

            chtLocalidad.Series.Add(serieLocalidad);


        }

        private void btnGraficarTotal_Click(object sender, EventArgs e)
        {
            DataTable tablaTotal = conexion.ObtenerProduccionTotal();
            chtTotal.Series.Clear();
            chtTotal.Titles.Clear();
            chtTotal.Titles.Add("Producción total por localidad");

            Series serieTotal = new Series("Total Producción");
            serieTotal.ChartType = SeriesChartType.Pie;

            foreach (DataRow fila in tablaTotal.Rows)
            {
                serieTotal.Points.AddXY(fila["Localidad"].ToString(), Convert.ToInt32(fila["TotalProduccion"]));
            }

            chtTotal.Series.Add(serieTotal);
        }
    }
    
}
