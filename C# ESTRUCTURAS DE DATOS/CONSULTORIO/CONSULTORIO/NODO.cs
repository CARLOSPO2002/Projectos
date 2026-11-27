using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSULTORIO
{
    internal class NODO
    {
        private paciente Cita;
        private NODO iz;
        private NODO de;

        public paciente Cita1 { get => Cita;set => Cita = value;  }
        public NODO Izq { get => iz; set => iz = value; }
        public NODO Der { get => de;set=> de= value; }

        public NODO()
        {
            Cita = Cita1;
            iz = null;
            de= null;
        }
    }
}
