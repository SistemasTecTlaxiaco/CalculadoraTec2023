using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLi;

namespace Calculadoraa
{
    public partial class CALCULADORA : Form
    {
        public CALCULADORA()
        {
            InitializeComponent();
        }
        bool secuencia = true;
        string operacion,borrado;
        double numero1,numero2,resultado;
        int res;
        private void bt1_Click(object sender, EventArgs e)
        {
        if (secuencia==true)
            {
                Resultado.Text = "";
                Resultado.Text = "1";
                secuencia = false;
            }
        else{
                Resultado.Text = Resultado.Text + "1";
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "2";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "2";
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "3";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "3";
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "4";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "4";
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "5";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "5";
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "6";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "6";
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "7";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "7";
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "8";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "8";
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "9";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "9";
            }
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            if (Resultado.Text == "0")
            {
                return;
            }
            else
            {
                Resultado.Text = Resultado.Text + "0";
            }
        }

        private void btsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            numero1 = double.Parse(Resultado.Text);
            secuencia = true;
        }

        private void btmultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            numero1 = double.Parse(Resultado.Text);
            secuencia = true;
        }

        private void btdivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            numero1 = double.Parse(Resultado.Text);
            secuencia = true;
        }

        private void btporcentaje_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Resultado.Text);
            resultado = ((numero1 * numero2) / 100);
            Resultado.Text = resultado.ToString();
            secuencia = true;
        }

        private void btfraccion_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Resultado.Text);
            resultado = 1 / numero1;
            Resultado.Text = resultado.ToString();
            secuencia = true;
        }

        private void btigual_Click(object sender, EventArgs e)
        {
            numero2= double.Parse(Resultado.Text);
            if (operacion=="+")
            {

                resultado = Class1.sumar(numero1, numero2);
                Resultado.Text =resultado.ToString();
                secuencia=true;
            }
            if (operacion == "-")
            {
                resultado = Class1.resta(numero1,numero2);
                Resultado.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "*")
            {
                resultado = Class1.multiplicar(numero1,numero2);
                Resultado.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "/")
            {
                resultado = Class1.dividir(numero1, numero2);
                Resultado.Text = resultado.ToString();
                secuencia = true;
            }
          

        }

        private void btretroceso_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado=Resultado.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0,x);
            Resultado.Text = borrado;

            if(Resultado.Text =="")
            {
                Resultado.Text = "0";
                secuencia=true;
            }
            if(Resultado.Text =="-")
            {
                Resultado.Text="0";
                secuencia=true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btborrar_Click(object sender, EventArgs e)
        {
            Resultado.Text = "0";
            numero1 = 0;
            numero2 = 0;
            secuencia = true;

        }

        private void btraiz_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Resultado.Text);
            resultado = Math.Sqrt (numero1);
            Resultado.Text = resultado.ToString();
            secuencia = true;
        }

        private void btpotencia_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Resultado.Text);
            resultado = numero1 * numero1;
            Resultado.Text = resultado.ToString();
            secuencia = true;
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void CALCULADORA_Load(object sender, EventArgs e)
        {

        }

        private void btpunto_Click(object sender, EventArgs e)
        {

        }
    }
}
