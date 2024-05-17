namespace pryEstructuraDatos
{
    partial class frmConsultasBD
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
            this.dgvBaseDatosConsulta = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatosConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBaseDatosConsulta
            // 
            this.dgvBaseDatosConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatosConsulta.Location = new System.Drawing.Point(48, 271);
            this.dgvBaseDatosConsulta.Name = "dgvBaseDatosConsulta";
            this.dgvBaseDatosConsulta.Size = new System.Drawing.Size(817, 229);
            this.dgvBaseDatosConsulta.TabIndex = 7;
            // 
            // btnListar
            // 
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(762, 238);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(103, 27);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(48, 53);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(817, 179);
            this.txtQuery.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consulta en SQL:";
            // 
            // frmConsultasBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 527);
            this.Controls.Add(this.dgvBaseDatosConsulta);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultasBD";
            this.Text = "frmConsultasBD";
            this.Load += new System.EventHandler(this.frmConsultasBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatosConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseDatosConsulta;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label label1;
    }
}