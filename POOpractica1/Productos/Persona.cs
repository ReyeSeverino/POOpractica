using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOpractica1
{
    internal class Persona
    {
        private string Nombre;
        private string Dni;
        string Ciudad;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        //public string Dni1 { get => Dni; set => Dni = value; }
        //public string Ciudad1 { get => Ciudad; set => Ciudad = value; }

        public string Ciudad1
        {
            get { return "Tu Ciudad es: " + Ciudad; }
            set { Ciudad = value; }
        }

        public string dni { get; set; }
    }
}
