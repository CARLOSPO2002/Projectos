using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTalumnos
{
    internal class Alumnos
    {
        private string matricula;
        private string nombre;

        public string Mat { get => matricula; set =>matricula = value; }   
        public string Nom { get => nombre;set=>nombre= value; }

        public Alumnos(string matri,string Nomb)
        {
            matricula = matri;
            nombre = Nomb;
        }
    }
}
