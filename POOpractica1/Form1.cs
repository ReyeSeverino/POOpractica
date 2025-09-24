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
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_llamar_Click(object sender, EventArgs e)
        {
            Motorolla.Llamar();
            
        }
    }
}
