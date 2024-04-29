using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsArbolBinario
    {
        //campos
        private clsNodo PrimerNodo;

        //propiedades
        public clsNodo Raiz {get { return PrimerNodo;} set {  PrimerNodo = value;}}

        //metodos
        public void Agregar(clsNodo nuevo)
        {
            nuevo.Izquierdo = null;
            nuevo.Derecho = null;
            if (Raiz== null)
            {
                Raiz = nuevo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo aux = Raiz;

                while (aux != null)
                {
                    NodoPadre = aux;
                    if (nuevo.Codigo < aux.Codigo )
                    {
                        aux = aux.Izquierdo;
                    }
                    else
                    {
                        aux = aux.Derecho;
                    }
                }
                //afuera del while
                if (nuevo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = nuevo;
                }
                else
                {
                    NodoPadre.Derecho = nuevo;
                }
            }
        }

        //
        public void Recorrer(DataGridView grilla)
        {
            grilla.Rows.Clear();
            InOrderAsc(grilla, Raiz);
        }
        //metodo recursivo- se vuelve a llamar a si mismo hasta cumplir la condicion
        public void InOrderAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo !=null)
            {
                InOrderAsc(dgv, R.Izquierdo);
            }
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

            if (R.Derecho != null)
            {
                InOrderAsc(dgv, R.Derecho);
            }
        }

        public void Recorrer(ListBox lista)
        {
            lista.Items.Clear();
            InOrderAsc(lista, Raiz);
        }
        //metodo recursivo- se vuelve a llamar a si mismo hasta cumplir la condicion
        public void InOrderAsc(ListBox lst, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrderAsc(lst, R.Izquierdo);
            }
            lst.Items.Add(R.Codigo);

            if (R.Derecho != null)
            {
                InOrderAsc(lst, R.Derecho);
            }
        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Àrbol");
            tree.Nodes.Add(NodoPadre);
            PreOrder(Raiz, NodoPadre);
            tree.ExpandAll();
        }
        public void PreOrder(clsNodo R, TreeNode nodoTv)
        {
            TreeNode NodoPadre = new TreeNode();
            nodoTv.Nodes.Add(NodoPadre);
            
            if (R.Izquierdo != null)
            {
                PreOrder(R.Izquierdo,nodoTv);
            }

            if (R.Derecho != null)
            {
                PreOrder(R.Derecho,nodoTv);
            }
        }

    }
}