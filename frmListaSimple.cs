﻿using System;
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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple listaSimple = new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nodoLista = new clsNodo();
            nodoLista.Codigo = Convert.ToInt32(txtCodigo.Text);
            nodoLista.Nombre = txtNombre.Text;
            nodoLista.Tramite = txtTramite.Text;
            listaSimple.AgregarNodoLista(nodoLista);
            listaSimple.Recorrer();
            listaSimple.Recorrer(listaLs);
            listaSimple.Recorrer(grillaLista);
            listaSimple.Recorrer(cmbLista);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 codigo = Convert.ToInt32(cmbLista.SelectedItem);
            
            if (listaSimple.Primero != null)
            {

                listaSimple.EliminarNodoLista(codigo);
                listaSimple.Recorrer(grillaLista);
                listaSimple.Recorrer();
                listaSimple.Recorrer(listaLs);
            }
            else
            {
                MessageBox.Show("lista vacia");
            }
        }
    }
}
