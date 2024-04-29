using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEstructuraDatos
{
    internal class clsNodo
    {
        //campos del nodo
        private Int32 cod;
        private String nom;
        private String tram;
        private clsNodo sig;
        private clsNodo ant;
        private clsNodo der;
        private clsNodo izq;
        //propiedades -> como un campo pero que permite codigo dentro
        //get para la lectura
        //set para la escritura
        public Int32 Codigo { get { return cod; } set { cod = value; } }
        public String Nombre { get { return nom; } set { nom = value; } }
        public String Tramite { get { return tram; } set { tram = value; } }
        public clsNodo Siguiente { get { return sig; } set { sig = value; } }
        public clsNodo Anterior { get { return ant; } set { ant = value; } }
        public clsNodo Izquierdo { get { return ant; } set { ant = value; } }
        public clsNodo Derecho { get {  return sig; } set { sig = value;} }
    }
}
