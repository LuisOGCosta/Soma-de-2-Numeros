﻿using System;
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

            int n1, n2, n3, total, media;

            //Entrada de Dados

            n1 = int.Parse(TxtNumero1.Text);
            n2 = int.Parse(TxtNumero2.Text);
            n3 = int.Parse(TxtNumero3.Text);

            //processamento

            total = n1 + n2 + n3;

            // Saidas de Dados

            LblTotal.Text = total.ToString();

            //Calculando Medía

            media = (n1 + n2 + n3) / 3;

            //Processamento d Medía

            lblMedia.Text = media.ToString();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
