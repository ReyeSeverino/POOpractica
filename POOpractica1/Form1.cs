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

        Celular Motorolla = new Celular();
        //Celular Samsung = new Celular("Samsung");
        //Celular Iphone = new Celular("Apple", "Blanco", "Smartphone");
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ejecutar_Click(object sender, EventArgs e)
        {
            //Motorolla.Ejecutar();
            MessageBox.Show(Motorolla.Mensaje("Juan", "Hola mundo...!"));

        }
    }
}
