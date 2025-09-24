using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Celular
    {
        private string marca = "Apple";
        private string color;
        private string tipo;

        public void Llamar()
        {

            System.Windows.Forms.MessageBox.Show("Tu Movil es un: " + marca);

        }

        public void Mensaje() 
        {

        }

    }
}
