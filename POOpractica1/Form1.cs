using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos;

namespace POOpractica1
{
    public partial class Form1 : Form
    {

        Celular Motorolla = new Celular(); //Se crea el objeto
        Celular Samsung = new Celular("Samsung"); //Se le asigna el valor al parametro M
        Celular Iphone = new Celular("Apple", "Blanco", "Smartphone");
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ejecutar_Click(object sender, EventArgs e)
        {
            Motorolla.Ejecutar();
            Samsung.Ejecutar(); //Se llama al metodo Ejecutar del objeto Samsung
            Iphone.Ejecutar();

        }
    }
}
