using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        string status = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (operacao == "" && status == "Actived")
            {
                Result.Text = "0";
                status = "";
            }
            else
            {
                Result.Text += "0";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (operacao == "" && status == "Actived")
            {
                Result.Text = "7";
                status = "";
            }
            else
            {
                Result.Text += "7";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operacao == "" && status == "Actived")
            {
                Result.Text = "4";
                status = "";
            }
            else
            {
                Result.Text += "4";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operacao == "" && status == "Actived")
            {
                Result.Text = "1";
                status = "";
            }
            else
            {
                Result.Text += "1";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operacao == "" && status == "Actived")
            {
                Result.Text = "2";
                status = "";
            }
            else
            {
                Result.Text += "2";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operacao == "" && status == "Actived")
            {
                Result.Text = "5";
                status = "";
            }
            else
            {
                Result.Text += "5";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operacao == "" && status == "Actived")
            {
                Result.Text = "8";
                status = "";
            }
            else
            {
                Result.Text += "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operacao == "" && status == "Actived")
            {
                Result.Text = "9";
                status = "";
            }
            else
            {
                Result.Text += "9";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operacao == "" && status == "Actived")
            {
                Result.Text = "6";
                status = "";
            }
            else
            {
                Result.Text += "6";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operacao == "" && status == "Actived")
            {
                Result.Text = "3";
                status = "";
            }
            else
            {
                Result.Text += "3";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Result.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Result.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                valor2 = decimal.Parse(Result.Text, CultureInfo.InvariantCulture);
                if (operacao == "SOMA")
                {
                    Result.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "MULT")
                {
                    Result.Text = Convert.ToString(valor1 * valor2);
                }
                else if (operacao == "MENOS")
                {
                    Result.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "DIV")
                {
                    if (valor1 != 0)
                    {
                        Result.Text = Convert.ToString(valor1 / valor2);
                    }
                    else if (valor2 != 0)
                    {
                        Result.Text = Convert.ToString(valor1 / valor2);
                    }
                }
                valor1 = 0;
                valor2 = 0;
                operacao = "";
                status = "Actived";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                valor1 = decimal.Parse(Result.Text, CultureInfo.InvariantCulture);
                Result.Text = " ";
                operacao = "SOMA";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                valor1 = decimal.Parse(Result.Text, CultureInfo.InvariantCulture);
                Result.Text = " ";
                operacao = "MULT";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                valor1 = decimal.Parse(Result.Text, CultureInfo.InvariantCulture);
                Result.Text = " ";
                operacao = "MENOS";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                valor1 = decimal.Parse(Result.Text, CultureInfo.InvariantCulture);
                Result.Text = " ";
                operacao = "DIV";
            }
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
