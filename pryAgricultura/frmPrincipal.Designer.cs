namespace pryAgricultura
{
    partial class frmPrincipal
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
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lstCultivo = new System.Windows.Forms.ListBox();
            this.txtProdToneladas = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblProdToneladas = new System.Windows.Forms.Label();
            this.btnProduccion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCultivos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(15, 44);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(249, 21);
            this.cboLocalidad.TabIndex = 0;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(12, 24);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(136, 17);
            this.lblLocalidad.TabIndex = 1;
            this.lblLocalidad.Text = "Selecccione localidad:";
            // 
            // lstCultivo
            // 
            this.lstCultivo.FormattingEnabled = true;
            this.lstCultivo.Location = new System.Drawing.Point(15, 146);
            this.lstCultivo.Name = "lstCultivo";
            this.lstCultivo.Size = new System.Drawing.Size(249, 212);
            this.lstCultivo.TabIndex = 2;
            // 
            // txtProdToneladas
            // 
            this.txtProdToneladas.Location = new System.Drawing.Point(323, 44);
            this.txtProdToneladas.Name = "txtProdToneladas";
            this.txtProdToneladas.Size = new System.Drawing.Size(187, 20);
            this.txtProdToneladas.TabIndex = 3;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(395, 117);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(115, 44);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // lblProdToneladas
            // 
            this.lblProdToneladas.AutoSize = true;
            this.lblProdToneladas.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdToneladas.Location = new System.Drawing.Point(348, 24);
            this.lblProdToneladas.Name = "lblProdToneladas";
            this.lblProdToneladas.Size = new System.Drawing.Size(162, 17);
            this.lblProdToneladas.TabIndex = 5;
            this.lblProdToneladas.Text = "Produccion en Toneladas:";
            // 
            // btnProduccion
            // 
            this.btnProduccion.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduccion.Location = new System.Drawing.Point(395, 201);
            this.btnProduccion.Name = "btnProduccion";
            this.btnProduccion.Size = new System.Drawing.Size(115, 55);
            this.btnProduccion.TabIndex = 6;
            this.btnProduccion.Text = "Ver Producciòn";
            this.btnProduccion.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(395, 300);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 44);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblCultivos
            // 
            this.lblCultivos.AutoSize = true;
            this.lblCultivos.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCultivos.Location = new System.Drawing.Point(12, 126);
            this.lblCultivos.Name = "lblCultivos";
            this.lblCultivos.Size = new System.Drawing.Size(184, 17);
            this.lblCultivos.TabIndex = 8;
            this.lblCultivos.Text = "Selecccione el tipo de cultivo:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(531, 384);
            this.Controls.Add(this.lblCultivos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProduccion);
            this.Controls.Add(this.lblProdToneladas);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtProdToneladas);
            this.Controls.Add(this.lstCultivo);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.cboLocalidad);
            this.Name = "frmPrincipal";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ListBox lstCultivo;
        private System.Windows.Forms.TextBox txtProdToneladas;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblProdToneladas;
        private System.Windows.Forms.Button btnProduccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCultivos;
    }
}