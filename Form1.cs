using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace How3
{
    public partial class Form1 : Form
    {
        private string tela = "0";
        private double resultado = 0;
        private string primeiroNumero = "";
        private string segundoNumero = "";
        private string sinal = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saida.Text = tela;
        }

        private void AddNumero(int numero) 
        { 
            if(sinal == "")
            {
                primeiroNumero += numero;
                saida.Text = primeiroNumero;
                tela = primeiroNumero;
            } 
            else 
            {
                segundoNumero += numero;
                tela = primeiroNumero + sinal + segundoNumero;
                saida.Text = tela;
            }


        }


        private void zero_Click(object sender, EventArgs e)
        {
            AddNumero(0);
        }

        private void um_Click(object sender, EventArgs e)
        {
            AddNumero(1);
        }

        private void dois_Click(object sender, EventArgs e)
        {
            AddNumero(2);
        }

        private void tres_Click(object sender, EventArgs e)
        {
            AddNumero(3);
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            AddNumero(4);
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            AddNumero(5);
        }

        private void seis_Click(object sender, EventArgs e)
        {
            AddNumero(6);
        }

        private void sete_Click(object sender, EventArgs e)
        {
            AddNumero(7);
        }

        private void oito_Click(object sender, EventArgs e)
        {
            AddNumero(8);
        }

        private void nove_Click(object sender, EventArgs e)
        {
            AddNumero(9);
        }

        private void ponto_Click(object sender, EventArgs e)
        {
            ponto.Enabled = false;
            if(sinal == "")
            {
                primeiroNumero += ".";
            }
            else
            {
                segundoNumero += ".";
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            switch(sinal)
            {
                case "+":
                    resultado = Double.Parse(primeiroNumero) + Double.Parse(segundoNumero);
                    break;

                case "-":
                    resultado = Double.Parse(primeiroNumero) - Double.Parse(segundoNumero);

                    break;

                case "*":
                    resultado = Double.Parse(primeiroNumero) * Double.Parse(segundoNumero);

                    break;

                case "/":
                    resultado = Double.Parse(primeiroNumero) / Double.Parse(segundoNumero);
                break;
            }

            tela = resultado + "";
            primeiroNumero = tela;
            segundoNumero = "";
            sinal = "";
            saida.Text = tela;
            ponto.Enabled = true;
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            sinal = "*";
            ponto.Enabled = true;
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            sinal = "/";
            ponto.Enabled = true;
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            sinal = "-";
            ponto.Enabled = true;
        }

        private void soma_Click(object sender, EventArgs e)
        {
            sinal = "+";
            ponto.Enabled = true;
        }

        private void c_Click(object sender, EventArgs e)
        {
            primeiroNumero = "";
            segundoNumero = "";
            sinal = "";
            tela = "";
            resultado = 0;
            saida.Text = "0";
            ponto.Enabled = true;
        }
    }
}
