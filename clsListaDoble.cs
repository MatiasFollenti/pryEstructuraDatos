using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEstructuraDatos
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;


        public clsNodo Primero { get { return pri; } set { pri = value; }  }
        public clsNodo Ultimo { get { return ult; } set { ult = value; } }


        public void AgregarNodo(clsNodo nuevoLD) 
        {
            if (Primero == null)
            {
                Primero = nuevoLD;
                Ultimo = nuevoLD;
            }
            else
            {
                if(nuevoLD.Codigo < Primero.Codigo)
                {
                    nuevoLD.Siguiente = Primero;
                    Primero.Anterior = nuevoLD;
                    Primero = nuevoLD;
                }
                else
                {
                    if (nuevoLD.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = nuevoLD;
                        nuevoLD.Anterior = Ultimo;
                        Ultimo = nuevoLD;
                    }
                    else
                    {
                        clsNodo Siguiente = Primero;
                        clsNodo Anterior = Primero;
                        while (Siguiente.Codigo < nuevoLD.Codigo)
                        {
                            Anterior = Siguiente;
                            Siguiente = Siguiente.Siguiente;
                        }
                        Anterior.Siguiente = nuevoLD;
                        nuevoLD.Siguiente = Siguiente;
                        Siguiente.Anterior = nuevoLD;
                        nuevoLD.Anterior = Anterior;

                    }
                }
            }
        }

        public void EliminarLD(Int32 codigo)
        {
            if (codigo == Primero.Codigo && Ultimo==Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
                if (codigo == Primero.Codigo)
            {
                Primero = Primero.Siguiente;
                Primero.Anterior = null;
            }
            else{
                if (Ultimo.Codigo == codigo)
                {
                    Ultimo = Ultimo.Anterior;
                    Ultimo.Siguiente = null;
                }
                else {
                    clsNodo Anterior = Primero;
                    clsNodo aux = Primero;
                    while (aux.Codigo != codigo)
                    {
                        Anterior = aux;
                        aux = aux.Siguiente;
                    }
                    Anterior.Siguiente = aux.Siguiente;
                    aux = aux.Siguiente;
                    aux.Anterior = Anterior;
                }
                
            }
        }



        public void RecorrerLD() 
        {
            clsNodo Aux = Primero;

            StreamWriter sw = new StreamWriter("ListaDoble.csv", false);
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
        public void RecorrerLD(ComboBox cmbListaD) 
        {
            clsNodo Aux = Primero;

            cmbListaD.Items.Clear();

            while (Aux != null)
            {
                cmbListaD.Items.Add(Aux.Codigo);

                Aux = Aux.Siguiente;
            }
        }
        public void RecorrerLD(ListBox lstListaD) 
        {
            clsNodo Aux = Primero;

            lstListaD.Items.Clear();

            while (Aux != null)
            {
                lstListaD.Items.Add(Aux.Codigo);

                Aux = Aux.Siguiente;
            }
        }
        public void RecorrerLDdesc(DataGridView grillaListaD) 
        {
            clsNodo Aux = Ultimo;

            grillaListaD.Rows.Clear();

            while (Aux != null)
            {
                grillaListaD.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);

                Aux = Aux.Anterior;
            }
        }


        public void RecorrerLD(DataGridView grillaListaD)
        {
            clsNodo Aux = Primero;

            grillaListaD.Rows.Clear();

            while (Aux != null)
            {
                grillaListaD.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);

                Aux = Aux.Siguiente;
            }
        }
    }
}
