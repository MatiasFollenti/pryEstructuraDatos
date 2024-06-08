namespace pryEstructuraDatos
{
    partial class frmRepasoOp
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
            this.dgvBaseDatosRepasoOperaciones = new System.Windows.Forms.DataGridView();
            this.lblListar = new System.Windows.Forms.Label();
            this.cbOperacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatosRepasoOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBaseDatosRepasoOperaciones
            // 
            this.dgvBaseDatosRepasoOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatosRepasoOperaciones.Location = new System.Drawing.Point(64, 228);
            this.dgvBaseDatosRepasoOperaciones.Name = "dgvBaseDatosRepasoOperaciones";
            this.dgvBaseDatosRepasoOperaciones.Size = new System.Drawing.Size(1046, 269);
            this.dgvBaseDatosRepasoOperaciones.TabIndex = 9;
            // 
            // lblListar
            // 
            this.lblListar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblListar.Location = new System.Drawing.Point(64, 62);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(781, 145);
            this.lblListar.TabIndex = 8;
            // 
            // cbOperacion
            // 
            this.cbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperacion.FormattingEnabled = true;
            this.cbOperacion.Items.AddRange(new object[] {
            "UNION 1",
            "UNION 2",
            "INTERSECCIÓN 1",
            "INTERSECCION 2",
            "DIFERENCIA 1",
            "DIFERENCIA 2",
            "SELECCION SIMPLE 1",
            "SELECCION SIMPLE 2",
            "SEL. MULTIATRIBUTO X INTERSECCION 1",
            "SEL. MULTIATRIBUTO X INTERSECCION 2",
            "SEL. MULTIATRIBUTO X CONVOLUCION 1",
            "SEL. MULTIATRIBUTO X CONVOLUCION 2",
            "ORDEN 1 ",
            "ORDEN 2",
            "PROYECCION X UN ATRIBUTO 1",
            "PROYECCION X UN ATRIBUTO 2",
            "PROYECCION MULTIATRIBUTO 1",
            "PROYECCION MULTIATRIBUTO 2",
            "JUNTAR 1",
            "JUNTAR 2"});
            this.cbOperacion.Location = new System.Drawing.Point(320, 25);
            this.cbOperacion.Name = "cbOperacion";
            this.cbOperacion.Size = new System.Drawing.Size(525, 23);
            this.cbOperacion.TabIndex = 6;
            this.cbOperacion.SelectedIndexChanged += new System.EventHandler(this.cbOperacion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Operación a realizar en la base de datos:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(61, 529);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(16, 13);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "---";
            // 
            // frmRepasoOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 655);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dgvBaseDatosRepasoOperaciones);
            this.Controls.Add(this.lblListar);
            this.Controls.Add(this.cbOperacion);
            this.Controls.Add(this.label1);
            this.Name = "frmRepasoOp";
            this.Text = "frmRepasoOp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatosRepasoOperaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseDatosRepasoOperaciones;
        private System.Windows.Forms.Label lblListar;
        private System.Windows.Forms.ComboBox cbOperacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigo;
    }
}