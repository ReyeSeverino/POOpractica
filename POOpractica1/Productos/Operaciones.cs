using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOpractica1.Productos
{
    internal class Operaciones
    {

        public static int n1 = 10; //al ser static se puede usar sin crear un objeto en otra parte del codigo
        public int n2 = 100;//no es static por lo que se necesita crear un objeto para usarla

        public static int Sumar(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
