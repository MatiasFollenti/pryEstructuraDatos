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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        clsListaDoble ld = new clsListaDoble();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();
            nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nodo.Nombre = txtNombre.Text;
            nodo.Tramite = txtTramite.Text;
            ld.AgregarNodo(nodo);
            ld.RecorrerLD();
            ld.RecorrerLD(grillaListaD);
            ld.RecorrerLD(listaLsD);
            ld.RecorrerLD(cmbListaD);
            txtTramite.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 codigo = Convert.ToInt32(cmbListaD.Text);
            ld.EliminarLD(codigo);
            ld.RecorrerLD();
           
            ld.RecorrerLD(listaLsD);
            ld.RecorrerLD(cmbListaD);
            cmbListaD.Text = "";

            if (radioButton1.Checked == true)
            {
                ld.RecorrerLD(grillaListaD);
            }
            else
            {
                ld.RecorrerLDdesc(grillaListaD);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ld.RecorrerLD(grillaListaD);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ld.RecorrerLDdesc(grillaListaD);
        }
    }
}
