using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEstructuraDatos
{
    internal class clsCola
    {
        //campos
        private clsNodo pri;
        private clsNodo ult;

        //propiedades

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        //procedimientos

        public void AgregarNodo(clsNodo nuevoNodo) 
        {
            if (Primero == null)
            {
                Primero = nuevoNodo;
                Ultimo = nuevoNodo;
            }
            else 
            { 
                Ultimo.Siguiente = nuevoNodo; //para enlazar nodos
                Ultimo = nuevoNodo;           //para señalar al ultimo
            } 
        }

        public void EliminarNodo() 
        {
            if (Primero == Ultimo) 
            {
                Primero = null;
                Ultimo = null;
            }
            else 
            {
                Primero = Primero.Siguiente;
            }
                
        }

        public void Recorrer(DataGridView grilla) 
        {
            clsNodo Aux = Primero;

            grilla.Rows.Clear();

            while(Aux != null) 
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

            StreamWriter sw = new StreamWriter("Cola.csv", true);
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
    }
}
