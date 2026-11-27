using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARBOLES_BINARIOS
{
    internal class NODO
    {
        private int dato;

        private NODO izq;
        private NODO der;

        public int Dato { get=>  dato; set=> dato = value;}
        internal NODO Izq { get => izq;set=> izq = value; }
        internal NODO der { get => der;set=> der = value; }

        public NODO()
        {
            dato = 0;
            izq = null;
            der = null;
        }
    }
}
