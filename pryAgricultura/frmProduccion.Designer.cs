namespace pryAgricultura
{
    partial class frmProduccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabProdcuccion = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chtLocalidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.chtTotal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGraficarTotal = new System.Windows.Forms.Button();
            this.tabProdcuccion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProdcuccion
            // 
            this.tabProdcuccion.Controls.Add(this.tabPage1);
            this.tabProdcuccion.Controls.Add(this.tabPage2);
            this.tabProdcuccion.Location = new System.Drawing.Point(12, 12);
            this.tabProdcuccion.Name = "tabProdcuccion";
            this.tabProdcuccion.SelectedIndex = 0;
            this.tabProdcuccion.Size = new System.Drawing.Size(648, 426);
            this.tabProdcuccion.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblLocalidad);
            this.tabPage1.Controls.Add(this.cboLocalidad);
            this.tabPage1.Controls.Add(this.btnGraficar);
            this.tabPage1.Controls.Add(this.chtLocalidad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(640, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Producciòn por Localidad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGraficarTotal);
            this.tabPage2.Controls.Add(this.chtTotal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(640, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Producciòn Total";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chtLocalidad
            // 
            chartArea1.Name = "ChartArea1";
            this.chtLocalidad.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtLocalidad.Legends.Add(legend1);
            this.chtLocalidad.Location = new System.Drawing.Point(25, 86);
            this.chtLocalidad.Name = "chtLocalidad";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtLocalidad.Series.Add(series1);
            this.chtLocalidad.Size = new System.Drawing.Size(586, 294);
            this.chtLocalidad.TabIndex = 0;
            this.chtLocalidad.Text = "chart1";
            // 
            // btnGraficar
            // 
            this.btnGraficar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficar.Location = new System.Drawing.Point(487, 22);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(115, 44);
            this.btnGraficar.TabIndex = 5;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(22, 17);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(136, 17);
            this.lblLocalidad.TabIndex = 7;
            this.lblLocalidad.Text = "Selecccione localidad:";
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(25, 37);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(249, 21);
            this.cboLocalidad.TabIndex = 6;
            // 
            // chtTotal
            // 
            chartArea2.Name = "ChartArea1";
            this.chtTotal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtTotal.Legends.Add(legend2);
            this.chtTotal.Location = new System.Drawing.Point(26, 91);
            this.chtTotal.Name = "chtTotal";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtTotal.Series.Add(series2);
            this.chtTotal.Size = new System.Drawing.Size(586, 294);
            this.chtTotal.TabIndex = 1;
            this.chtTotal.Text = "chart1";
            // 
            // btnGraficarTotal
            // 
            this.btnGraficarTotal.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficarTotal.Location = new System.Drawing.Point(497, 21);
            this.btnGraficarTotal.Name = "btnGraficarTotal";
            this.btnGraficarTotal.Size = new System.Drawing.Size(115, 44);
            this.btnGraficarTotal.TabIndex = 6;
            this.btnGraficarTotal.Text = "Graficar";
            this.btnGraficarTotal.UseVisualStyleBackColor = true;
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.tabProdcuccion);
            this.Name = "frmProduccion";
            this.Text = "Producciòn";
            this.tabProdcuccion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProdcuccion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtLocalidad;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox cboLocalidad;
        private System.Windows.Forms.Button btnGraficarTotal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtTotal;
    }
}