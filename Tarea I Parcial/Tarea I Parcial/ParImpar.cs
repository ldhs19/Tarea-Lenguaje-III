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
    public partial class Tarea_Par_Impar : Form
    {
        public Tarea_Par_Impar()
        {
            InitializeComponent();
        }

        private void verbutton_Click(object sender, EventArgs e)
        {
          decimal Num1 = 0;

            Num1 = Convert.ToDecimal(Num1textBox);

            if (Num1 % 2 == 0)
            {
                MessageBox.Show("el numero es par");
            }

            else
            {
                MessageBox.Show("el numero es Impar");
            }
        }
       

            
    }
}
