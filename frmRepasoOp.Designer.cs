﻿namespace pryEstructuraDatos
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
            this.btnListar = new System.Windows.Forms.Button();
            this.cbOperacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatosRepasoOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBaseDatosRepasoOperaciones
            // 
            this.dgvBaseDatosRepasoOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatosRepasoOperaciones.Location = new System.Drawing.Point(64, 228);
            this.dgvBaseDatosRepasoOperaciones.Name = "dgvBaseDatosRepasoOperaciones";
            this.dgvBaseDatosRepasoOperaciones.Size = new System.Drawing.Size(781, 269);
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
            // btnListar
            // 
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(733, 24);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(112, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // cbOperacion
            // 
            this.cbOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperacion.FormattingEnabled = true;
            this.cbOperacion.Location = new System.Drawing.Point(320, 25);
            this.cbOperacion.Name = "cbOperacion";
            this.cbOperacion.Size = new System.Drawing.Size(407, 23);
            this.cbOperacion.TabIndex = 6;
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
            // frmRepasoOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 521);
            this.Controls.Add(this.dgvBaseDatosRepasoOperaciones);
            this.Controls.Add(this.lblListar);
            this.Controls.Add(this.btnListar);
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
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cbOperacion;
        private System.Windows.Forms.Label label1;
    }
}