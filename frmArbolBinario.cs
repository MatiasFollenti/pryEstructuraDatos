using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

       clsArbolBinario Arbol = new clsArbolBinario();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            Arbol.AgregarArbolBinario(ObjNodo);
            Arbol.RecorrerArbolBinario(dgvArbol);
            Arbol.RecorrerArbolBinario(cmbArbol);
            Arbol.RecorrerArbolBinario(treeArbol);
            Arbol.RecorrerArbolBinario(lstArbol);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

            
            optInOrderDesc.Checked = false;
            optPreOrder.Checked = false;
            optPostOrder.Checked = false;
        }

        private void cmbArbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArbol.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void optInOrderDesc_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerArbolDesc(dgvArbol);
            Arbol.RecorrerArbolDesc(cmbArbol);
            Arbol.RecorrerArbolDesc(lstArbol);
        }

        private void optInOrderAsc_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerArbolBinario(dgvArbol);
            Arbol.RecorrerArbolBinario(cmbArbol);
            Arbol.RecorrerArbolBinario(lstArbol);
        }

        private void optPreOrder_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerArbolPreOrden(dgvArbol);
            Arbol.RecorrerArbolPreOrden(lstArbol);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Arbol.Raiz != null)
            {
                Int32 x = Convert.ToInt32(cmbArbol.Text);
                Arbol.Eliminar(x);
                Arbol.RecorrerArbolBinario(dgvArbol);
                Arbol.RecorrerArbolBinario(cmbArbol);
                Arbol.RecorrerArbolBinario(lstArbol);
                Arbol.RecorrerArbolBinario(treeArbol);

                optInOrderDesc.Checked = false;
                optPreOrder.Checked = false;
                optPostOrder.Checked = false;
            }
            else
            {
                MessageBox.Show("El árbol esta vacío.");
            }
            cmbArbol.Text = "";
            btnEliminar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
            Arbol.RecorrerArbolBinario(treeArbol);
        }

        private void optPostOrder_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerArbolPostOrden(dgvArbol);
            Arbol.RecorrerArbolPostOrden(lstArbol);
        }
    }
}
