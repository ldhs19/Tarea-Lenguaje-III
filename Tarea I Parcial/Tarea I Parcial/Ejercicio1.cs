using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_I_Parcial
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Verbutton_Click(object sender, EventArgs e)
        {
            decimal numero1 = 0;
            decimal numero2 = 0;

            numero1 = Convert.ToDecimal(Numero1TextBox.text);
            numero2 = Convert.ToDecimal(Numero2textBox.text);
        }

        private void Numero1textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
