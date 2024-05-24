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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private Form formularioActual; // Variable para mantener referencia al formulario actualmente abierto
        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si hay un formulario actualmente abierto
            if (formularioActual != null)
            {
                formularioActual.Close(); // Cerrar el formulario actual si existe
            }

            // Crear una instancia del nuevo formulario
            frmDatosdelDesarrollador frmDesarrollador = new frmDatosdelDesarrollador();

            // Establecer el formulario secundario como hijo del panel contenedor
            frmDesarrollador.TopLevel = false;
            frmDesarrollador.FormBorderStyle = FormBorderStyle.None;
            frmDesarrollador.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(frmDesarrollador);

            // Mostrar el formulario secundario
            frmDesarrollador.Show();

            // Asignar el nuevo formulario como el formulario actual
            formularioActual = frmDesarrollador;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si hay un formulario actualmente abierto
            if (formularioActual != null)
            {
                formularioActual.Close(); // Cerrar el formulario actual si existe
            }

            // Crear una instancia del nuevo formulario
            frmCola nfrmCola = new frmCola();

            // Establecer el formulario secundario como hijo del panel contenedor
            nfrmCola.TopLevel = false;
            nfrmCola.FormBorderStyle = FormBorderStyle.None;
            nfrmCola.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(nfrmCola);

            // Mostrar el formulario secundario
            nfrmCola.Show();

            // Asignar el nuevo formulario como el formulario actual
            formularioActual = nfrmCola;
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si hay un formulario actualmente abierto
            if (formularioActual != null)
            {
                formularioActual.Close(); // Cerrar el formulario actual si existe
            }

            // Crear una instancia del nuevo formulario
            frmPila frmPila = new frmPila();

            // Establecer el formulario secundario como hijo del panel contenedor
            frmPila.TopLevel = false;
            frmPila.FormBorderStyle = FormBorderStyle.None;
            frmPila.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(frmPila);

            // Mostrar el formulario secundario
            frmPila.Show();

            // Asignar el nuevo formulario como el formulario actual
            formularioActual = frmPila;
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si hay un formulario actualmente abierto
            if (formularioActual != null)
            {
                formularioActual.Close(); // Cerrar el formulario actual si existe
            }

            // Crear una instancia del nuevo formulario
            frmListaSimple frmLista = new frmListaSimple();

            // Establecer el formulario secundario como hijo del panel contenedor
            frmLista.TopLevel = false;
            frmLista.FormBorderStyle = FormBorderStyle.None;
            frmLista.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(frmLista);

            // Mostrar el formulario secundario
            frmLista.Show();

            // Asignar el nuevo formulario como el formulario actual
            formularioActual = frmLista;
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si hay un formulario actualmente abierto
            if (formularioActual != null)
            {
                formularioActual.Close(); // Cerrar el formulario actual si existe
            }

            // Crear una instancia del nuevo formulario
            frmListaDoble frmListaDoble = new frmListaDoble();

            // Establecer el formulario secundario como hijo del panel contenedor
            frmListaDoble.TopLevel = false;
            frmListaDoble.FormBorderStyle = FormBorderStyle.None;
            frmListaDoble.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(frmListaDoble);

            // Mostrar el formulario secundario
            frmListaDoble.Show();

            // Asignar el nuevo formulario como el formulario actual
            formularioActual = frmListaDoble;
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si hay un formulario actualmente abierto
            if (formularioActual != null)
            {
                formularioActual.Close(); // Cerrar el formulario actual si existe
            }

            // Crear una instancia del nuevo formulario
            frmArbolBinario frmArbolBinario = new frmArbolBinario();

            // Establecer el formulario secundario como hijo del panel contenedor
            frmArbolBinario.TopLevel = false;
            frmArbolBinario.FormBorderStyle = FormBorderStyle.None;
            frmArbolBinario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(frmArbolBinario);

            // Mostrar el formulario secundario
            frmArbolBinario.Show();

            // Asignar el nuevo formulario como el formulario actual
            formularioActual = frmArbolBinario;
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si hay un formulario actualmente abierto
            if (formularioActual != null)
            {
                formularioActual.Close(); // Cerrar el formulario actual si existe
            }

            // Crear una instancia del nuevo formulario
            frmConsultasBD frmConsultasBD = new frmConsultasBD();

            // Establecer el formulario secundario como hijo del panel contenedor
            frmConsultasBD.TopLevel = false;
            frmConsultasBD.FormBorderStyle = FormBorderStyle.None;
            frmConsultasBD.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(frmConsultasBD);

            // Mostrar el formulario secundario
            frmConsultasBD.Show();

            // Asignar el nuevo formulario como el formulario actual
            formularioActual = frmConsultasBD;
        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si hay un formulario actualmente abierto
            if (formularioActual != null)
            {
                formularioActual.Close(); // Cerrar el formulario actual si existe
            }

            // Crear una instancia del nuevo formulario
            frmBDOperaciones frmBDOperaciones = new frmBDOperaciones();

            // Establecer el formulario secundario como hijo del panel contenedor
            frmBDOperaciones.TopLevel = false;
            frmBDOperaciones.FormBorderStyle = FormBorderStyle.None;
            frmBDOperaciones.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(frmBDOperaciones);

            // Mostrar el formulario secundario
            frmBDOperaciones.Show();

            // Asignar el nuevo formulario como el formulario actual
            formularioActual = frmBDOperaciones;
        }

        private void repasoOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si hay un formulario actualmente abierto
            if (formularioActual != null)
            {
                formularioActual.Close(); // Cerrar el formulario actual si existe
            }

            // Crear una instancia del nuevo formulario
            frmRepasoOp frmRepasoOp = new frmRepasoOp();

            // Establecer el formulario secundario como hijo del panel contenedor
            frmRepasoOp.TopLevel = false;
            frmRepasoOp.FormBorderStyle = FormBorderStyle.None;
            frmRepasoOp.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(frmRepasoOp);

            // Mostrar el formulario secundario
            frmRepasoOp.Show();

            // Asignar el nuevo formulario como el formulario actual
            formularioActual = frmRepasoOp;
        }
    }
}
