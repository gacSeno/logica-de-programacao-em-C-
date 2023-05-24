using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            double quantidade = double.Parse(txtQuantidade.Text);

            switch (codigo.ToUpper())
            {
                case "AUTO":
                    lblResultado.Text = "Serão pagos R$" + (quantidade * 325);

                    
                
                break;

                case "MOTO":
                    
                    lblResultado.Text = "Serão pagos R$" + (quantidade * 102);

                break;

                case "BIKE":

                    lblResultado.Text = "Serão pagos R$" + (quantidade * 76);

                    break;

                case "KLWE":

                    lblResultado.Text = "Serão pagos R$" + (quantidade * 176);

                    break;

                case "WPDD":

                    lblResultado.Text = "Serão pagos R$" + (quantidade * 456);

                    break;






            }
        }
    }
}
