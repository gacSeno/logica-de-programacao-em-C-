using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_pag_35_2_3_e_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            string classe = txtClasse.Text;

            double horas =  double.Parse(txtHoras.Text);

            switch (classe.ToUpper())
            {
                case "A":

                    lblResultado.Text = "total de salario:" + (8 * horas).ToString();
                    break;


                    case "B":
                    lblResultado.Text = "total de salario:" + (12 * horas).ToString();

                    break;

                    case"C":
                    lblResultado.Text = "total de salario:" + (17 * horas).ToString();

                    break;

                    default:

                    lblResultado.Text = "classe invalida/nao existente";

                    break;


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
