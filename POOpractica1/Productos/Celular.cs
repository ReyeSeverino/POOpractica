using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Celular
    {
        private string Marca;
        private string Color;
        private string Tipo;

        public Celular() //shortcut ctor + tab + tab para crear constructor
        {
            //este metodo se ejecuta automaticamente al crear un objeto
            //se usa para inicializar las variables de la clase
            Marca = "Nokia";
            Color = "azul";
            Tipo = "Smartphone";
        }

        public void Llamar()
        {

            System.Windows.Forms.MessageBox.Show("Tu Movil es un: " + Marca);

        }

        public void Mensaje() 
        {

        }

    }
}
