using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEstructuraDatos
{
    internal class clsPila
    {
        //campos
        private clsNodo pri;
        
        //propiedades
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        //metodos

        public void AgregarNodo(clsNodo nuevoPila) 
        {
            if (Primero == null)
            {
                Primero = nuevoPila;
                
            }
            else
            {
                nuevoPila.Siguiente = Primero;
                Primero = nuevoPila;
            }

            
        }

        public void EliminarNodo() 
        {
            if (Primero !=null) 
            {
                Primero = Primero.Siguiente;
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
    }
}
