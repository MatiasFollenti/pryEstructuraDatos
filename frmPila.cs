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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        private void frmPila_Load(object sender, EventArgs e)
        {

        }

        clsPila pila = new clsPila();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nodoPila = new clsNodo();
            nodoPila.Codigo = Convert.ToInt32(txtCodigo.Text);
            nodoPila.Nombre= txtNombre.Text;
            nodoPila.Tramite = txtTramite.Text;
            pila.AgregarNodo(nodoPila);
            pila.Recorrer();
            pila.Recorrer(grillaPila);
            pila.Recorrer(listaPila);
            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pila.Primero != null)
            {
                lblCodigo.Text = pila.Primero.Codigo.ToString();
                lblNombre.Text = pila.Primero.Nombre;
                lblTramite.Text = pila.Primero.Tramite.ToString();
                pila.EliminarNodo();
                pila.Recorrer(grillaPila);
                pila.Recorrer();
                pila.Recorrer(listaPila);
            }
            else
            {
                lblCodigo.Text = "";
                lblNombre.Text = "";
                lblTramite.Text = "";
            }
        }
    }
}
