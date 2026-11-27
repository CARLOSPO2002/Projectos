using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSULTORIO
{
    
    public struct paciente
    {
        public int turno;
        public string Nombre;
        public DateTime FechaCita;

        public paciente(int Turno,string Nombre,DateTime fecha)
        {
            turno = Turno;
            this.Nombre = Nombre;
            this.FechaCita = fecha;
        }
    }
}
