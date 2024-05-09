namespace pryEstructuraDatos
{
    partial class frmArbolBinario
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
            this.dgvArbol = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbArbol = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbNuevo = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.treeArbol = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optPostOrder = new System.Windows.Forms.RadioButton();
            this.optPreOrder = new System.Windows.Forms.RadioButton();
            this.optInOrderDesc = new System.Windows.Forms.RadioButton();
            this.optInOrderAsc = new System.Windows.Forms.RadioButton();
            this.lstArbol = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbNuevo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArbol
            // 
            this.dgvArbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColNombre,
            this.ColTramite});
            this.dgvArbol.Location = new System.Drawing.Point(378, 263);
            this.dgvArbol.Name = "dgvArbol";
            this.dgvArbol.Size = new System.Drawing.Size(361, 320);
            this.dgvArbol.TabIndex = 20;
            // 
            // ColCodigo
            // 
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.Name = "ColCodigo";
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            // 
            // ColTramite
            // 
            this.ColTramite.HeaderText = "Trámite";
            this.ColTramite.Name = "ColTramite";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbArbol);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(670, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 150);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Elemento";
            // 
            // cmbArbol
            // 
            this.cmbArbol.FormattingEnabled = true;
            this.cmbArbol.Location = new System.Drawing.Point(99, 37);
            this.cmbArbol.Name = "cmbArbol";
            this.cmbArbol.Size = new System.Drawing.Size(121, 28);
            this.cmbArbol.TabIndex = 13;
            this.cmbArbol.SelectedIndexChanged += new System.EventHandler(this.cmbArbol_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(99, 90);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 39);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Código:";
            // 
            // gbNuevo
            // 
            this.gbNuevo.Controls.Add(this.txtTramite);
            this.gbNuevo.Controls.Add(this.btnAgregar);
            this.gbNuevo.Controls.Add(this.txtNombre);
            this.gbNuevo.Controls.Add(this.txtCodigo);
            this.gbNuevo.Controls.Add(this.label3);
            this.gbNuevo.Controls.Add(this.label2);
            this.gbNuevo.Controls.Add(this.label1);
            this.gbNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNuevo.Location = new System.Drawing.Point(337, 13);
            this.gbNuevo.Name = "gbNuevo";
            this.gbNuevo.Size = new System.Drawing.Size(310, 244);
            this.gbNuevo.TabIndex = 18;
            this.gbNuevo.TabStop = false;
            this.gbNuevo.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(110, 121);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(175, 26);
            this.txtTramite.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(142, 179);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 39);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 26);
            this.txtNombre.TabIndex = 10;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(110, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(175, 26);
            this.txtCodigo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trámite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(714, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Equilibrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeArbol
            // 
            this.treeArbol.Location = new System.Drawing.Point(12, 13);
            this.treeArbol.Name = "treeArbol";
            this.treeArbol.Size = new System.Drawing.Size(272, 309);
            this.treeArbol.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optPostOrder);
            this.groupBox1.Controls.Add(this.optPreOrder);
            this.groupBox1.Controls.Add(this.optInOrderDesc);
            this.groupBox1.Controls.Add(this.optInOrderAsc);
            this.groupBox1.Location = new System.Drawing.Point(12, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 222);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado del arbol";
            // 
            // optPostOrder
            // 
            this.optPostOrder.AutoSize = true;
            this.optPostOrder.Location = new System.Drawing.Point(20, 148);
            this.optPostOrder.Name = "optPostOrder";
            this.optPostOrder.Size = new System.Drawing.Size(78, 17);
            this.optPostOrder.TabIndex = 26;
            this.optPostOrder.TabStop = true;
            this.optPostOrder.Text = "Post- Order";
            this.optPostOrder.UseVisualStyleBackColor = true;
            this.optPostOrder.CheckedChanged += new System.EventHandler(this.optPostOrder_CheckedChanged);
            // 
            // optPreOrder
            // 
            this.optPreOrder.AutoSize = true;
            this.optPreOrder.Location = new System.Drawing.Point(20, 111);
            this.optPreOrder.Name = "optPreOrder";
            this.optPreOrder.Size = new System.Drawing.Size(73, 17);
            this.optPreOrder.TabIndex = 25;
            this.optPreOrder.TabStop = true;
            this.optPreOrder.Text = "Pre- Order";
            this.optPreOrder.UseVisualStyleBackColor = true;
            this.optPreOrder.CheckedChanged += new System.EventHandler(this.optPreOrder_CheckedChanged);
            // 
            // optInOrderDesc
            // 
            this.optInOrderDesc.AutoSize = true;
            this.optInOrderDesc.Location = new System.Drawing.Point(20, 74);
            this.optInOrderDesc.Name = "optInOrderDesc";
            this.optInOrderDesc.Size = new System.Drawing.Size(95, 17);
            this.optInOrderDesc.TabIndex = 24;
            this.optInOrderDesc.TabStop = true;
            this.optInOrderDesc.Text = "In Order DESC";
            this.optInOrderDesc.UseVisualStyleBackColor = true;
            this.optInOrderDesc.CheckedChanged += new System.EventHandler(this.optInOrderDesc_CheckedChanged);
            // 
            // optInOrderAsc
            // 
            this.optInOrderAsc.AutoSize = true;
            this.optInOrderAsc.Location = new System.Drawing.Point(20, 37);
            this.optInOrderAsc.Name = "optInOrderAsc";
            this.optInOrderAsc.Size = new System.Drawing.Size(87, 17);
            this.optInOrderAsc.TabIndex = 23;
            this.optInOrderAsc.TabStop = true;
            this.optInOrderAsc.Text = "In Order ASC";
            this.optInOrderAsc.UseVisualStyleBackColor = true;
            this.optInOrderAsc.CheckedChanged += new System.EventHandler(this.optInOrderAsc_CheckedChanged);
            // 
            // lstArbol
            // 
            this.lstArbol.FormattingEnabled = true;
            this.lstArbol.Location = new System.Drawing.Point(787, 261);
            this.lstArbol.Name = "lstArbol";
            this.lstArbol.Size = new System.Drawing.Size(258, 316);
            this.lstArbol.TabIndex = 23;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 589);
            this.Controls.Add(this.lstArbol);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeArbol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvArbol);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbNuevo);
            this.Name = "frmArbolBinario";
            this.Text = "frmArbolBinario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbNuevo.ResumeLayout(false);
            this.gbNuevo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTramite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbArbol;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbNuevo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeArbol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optPostOrder;
        private System.Windows.Forms.RadioButton optPreOrder;
        private System.Windows.Forms.RadioButton optInOrderDesc;
        private System.Windows.Forms.RadioButton optInOrderAsc;
        private System.Windows.Forms.ListBox lstArbol;
    }
}