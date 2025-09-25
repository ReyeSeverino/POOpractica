using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Celular //Clase es un molde o formulario vacio para crear objetos
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

        public Celular(string M) //Un constructor que recibe un parametro M que se utlizara para inicializar una de sus variables
        {
            Marca = M;
            Color = "Negro";
            Tipo = "Smartphone";
        }

        public Celular(string M, string C, string T)
        {
            Marca = M;
            Color = C;
            Tipo = T;
        }

        public void Ejecutar()
        {

            System.Windows.Forms.MessageBox.Show("Tu celular es un: "+ Marca +" Color: "+ Color +" y es Tipo: "+ Tipo);

        }

        public void Mensaje() 
        {

        }

    }
}
