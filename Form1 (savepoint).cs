using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma2Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variaveis

            int n1, n2, total;

            //Entrada de Dados

            n1 = int.Parse(TxtNumero1.Text);
            n2 = int.Parse(TxtNumero2.Text);

            //processamento

            total = n1 + n2;

            // Saidas de Dados

            LblTotal.Text = total.ToString();
            TxtTotal.Text = total.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
