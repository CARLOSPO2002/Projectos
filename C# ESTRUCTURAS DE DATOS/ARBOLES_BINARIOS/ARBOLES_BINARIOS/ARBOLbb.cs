using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARBOLES_BINARIOS
{
    internal class ARBOLbb
    {
        private NODO raiz;
        private NODO trabajo;// variable de apoyo
        private int i = 0;//un contador

        public ARBOLbb()
        {
            raiz = null;
        }
        public NODO RaizN { get => raiz; set=> raiz = value; }

        public NODO Insertar(int pDato, NODO pNodo)
        {
            NODO temp = null;

            if (pNodo == null)
            {
                temp = new NODO();
                temp.Dato = pDato;
                return temp;
            }
            if (pDato < pNodo.Dato)
            {
                pNodo.Izq = Insertar(pDato, pNodo.Izq);
            }
            if(pDato>pNodo.Dato)
            {
                pNodo.der= Insertar(pDato,pNodo.der);
            }
            return pNodo;
        }

    }
}
