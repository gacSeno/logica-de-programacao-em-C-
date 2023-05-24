using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace questao02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double km = double.Parse(txtKm.Text);
            double pagar =35;

            if (km < 80) {
                lblResultado.Text = ("vc foi multado,valor a pagar é" + km * pagar );
            }


            else { lblResultado.Text = ("kilometragem nromal"); }
                    
                    
        

            
        }
    }
}
