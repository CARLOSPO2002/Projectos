using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICA
{
    internal class Cliente
    {
        private int id=0;
        private string Nombre,ApellidoP,ApellidoM,Motivo;
        private DateTime fecha;

        public int i { get => id; }
        public string Nom { get=>Nombre; set=>Nombre = value; }
        public string ApeP { get => ApellidoP; set => ApellidoP = value; }
        public string ApeM {  get => ApellidoM; set => ApellidoM = value; }
        public string Moti {  get => Motivo; set => Motivo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public Cliente(int id, string nomb,string ApP,string ApM,string Mot,DateTime fe)
        {
            this.id = id;
            Nombre = nomb;
            ApellidoP=ApP;
            ApellidoM=ApM;
            Motivo=Mot;
            fecha = fe;
        }

    }
}
