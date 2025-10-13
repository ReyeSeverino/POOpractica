using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        Persona P = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ejecutar_Click(object sender, EventArgs e)
        {
            P.Nombre1 = "Jykpo";
            P.dni = "12345678";
            P.Ciudad1 = "Madrid";
            MessageBox.Show(P.dni);

        }
    }
}
