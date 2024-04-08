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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola cola = new clsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo =Convert.ToInt32(txtCodigo.Text) ;
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            cola.AgregarNodo(objNodo);
            cola.Recorrer();
            cola.Recorrer(grillaCola);
            cola.Recorrer(listaCola);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cola != null)
            {
                lblCodigo.Text = cola.Primero.Codigo.ToString();
                lblNombre.Text = cola.Primero.Nombre;
            }
        }
    }
}
