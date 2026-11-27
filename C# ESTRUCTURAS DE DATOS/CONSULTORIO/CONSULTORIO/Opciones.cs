using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSULTORIO
{
    internal class Opciones
    {
        private NODO raiz;
        private NODO aux;
        private int i = 0;

        public Opciones()
        {
            raiz = null;
        }

        public NODO Raiz { get => raiz;set=>raiz = value;  }

        public NODO Insertar(paciente pac,NODO pnodo)
        {
            NODO temp = null;
            if (pnodo == null)
            {
                temp = new NODO();
                temp.Cita1= pac;
                return temp;
            }
            if (pac.turno < pnodo.Cita1.turno)
            {
                pnodo.Izq = Insertar(pac, pnodo.Izq);
            }
            if (pac.turno > pnodo.Cita1.turno)
            {
                pnodo.Der=Insertar(pac, pnodo.Der);
            }
            return pnodo;
        }

        public void Mostrar(NODO pnodo)
        {
            if(pnodo == null)
            {
                Mostrar(pnodo.Izq);
                Console.WriteLine(pnodo.Cita1.turno);
                Console.WriteLine(pnodo.Cita1.Nombre);
                Console.WriteLine(pnodo.Cita1.FechaCita);
                Mostrar(pnodo.Der);
            }
        }
        
    }
}
