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

        public Celular() 
        {
            Marca = "Nokia";
            Color = "azul";
            Tipo = "Smartphone";
        }

        public Celular(string M)
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

        public void Ejecutar() //Este metodo no retorna ningun valor ya que es void
        {

            System.Windows.Forms.MessageBox.Show("Tu celular es un: "+ Marca +" Color: "+ Color +" y es Tipo: "+ Tipo);

        }

        public string Mensaje(string N, string Msj) //Este metodo retorna un valor de tipo string
        {
            string Nombre = N;
            string Enviando = Msj;

            string Mensaje = "El mensaje: " + Enviando + " fue enviado por: " + Nombre;

            return Mensaje;
        }

    }
}
