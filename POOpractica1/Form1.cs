using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POOpractica1.Productos;
using Productos;

namespace POOpractica1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Escribir_Click(object sender, EventArgs e)
        {
            TextWriter Escribir = new StreamWriter("Text.txt");
            Escribir.WriteLine("Hola Mundo");
            Escribir.Close();

            MessageBox.Show("Listo!");
        }
    }
}
