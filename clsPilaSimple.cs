using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsListaSimple
    {
        private clsNodo pri;

        public clsNodo Primero 
        {
            get { return pri; }
            set { pri = value; }
        }

        public void AgregarNodoLista(clsNodo nuevoLista) 
        {
            if (Primero == null)
            {
                Primero = nuevoLista;
            }
            else 
            {
                if (nuevoLista.Codigo <= Primero.Codigo) 
                {
                    nuevoLista.Siguiente = Primero;
                    Primero = nuevoLista;
                }
                else 
                {
                    clsNodo aux = Primero;
                    clsNodo Anterior = Primero;
                    while (aux !=null && nuevoLista.Codigo > aux.Codigo)
                    {
                        Anterior = aux;
                        aux = aux.Siguiente;
                    }
                    Anterior.Siguiente= nuevoLista;
                    nuevoLista.Siguiente = aux;

                }  
                
            }
        }

        public void EliminarNodoLista(Int32 codigo)
        {
            if (codigo == Primero.Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo anterior = Primero;
                clsNodo aux = Primero;
                while (aux.Codigo != codigo)
                {
                    anterior = aux;
                    aux = aux.Siguiente;
                }
                anterior.Siguiente = aux.Siguiente;
            }

        }

        public void Recorrer(DataGridView grilla)
        {
            clsNodo Aux = Primero;

            grilla.Rows.Clear();

            while (Aux != null)
            {
                grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);

                Aux = Aux.Siguiente;
            }

        }

        public void Recorrer(ListBox lista)
        {
            clsNodo Aux = Primero;

            lista.Items.Clear();

            while (Aux != null)
            {
                lista.Items.Add(Aux.Codigo);

                Aux = Aux.Siguiente;
            }

        }

        public void Recorrer()
        {
            clsNodo Aux = Primero;

            StreamWriter sw = new StreamWriter("Pila.csv", false);
            sw.WriteLine("Lista de espera");
            sw.WriteLine("Codigo;Nombre;Tramite");
            while (Aux != null)
            {
                sw.WriteLine(Aux.Codigo + ";" + Aux.Nombre + ";" + Aux.Tramite);

                Aux = Aux.Siguiente;
            }
            sw.Close();
            sw.Dispose();
        }

        public void Recorrer(ComboBox combo)
        {
            clsNodo Aux = Primero;
            combo.Items.Clear();
            while (Aux !=null)
            {
                combo.Items.Add(Aux.Nombre);
                Aux = Aux.Siguiente;
            }
        }
    }
}
