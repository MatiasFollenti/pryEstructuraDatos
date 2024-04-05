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
        //propiedades -> como un campo pero que permite codigo dentro
        //get para la lectura
        //set para la escritura
        public Int32 Cod { get { return cod; } set { cod = value; } }
        public String Nom { get { return nom; } set { nom = value; } }
        public String Tram { get { return tram; } set { tram = value; } }
        public clsNodo Sig { get { return sig; } set { sig = value; } }

    }
}
