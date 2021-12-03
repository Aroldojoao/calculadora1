using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSOMA_Click(object sender, EventArgs e)

        {

            double num1, num2, Resultado;

            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                Resultado = num1 + num2;
                txtResultado.Text = Resultado.ToString();
                MessageBox.Show("Passou no try operação concluida", "message");
            }
            catch (Exception)
            {
                MessageBox.Show("não foi possivel concluir", "message");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal numero1, numero2, numero, total;
            double num1, num2, Resultado;
            try

            {
                numero2 = Convert.ToDecimal(textBox1.Text);
                numero1 = Convert.ToDecimal(textBox2.Text);
                total = numero1 - numero2;
                txtResultado.Text = total.ToString();
                MessageBox.Show("testando variavel numero no TRY", "menssagem de alerta");
            }
            catch(Exception)
            {
                MessageBox.Show("teste de declaração numero no CATCH","Menssagem");
            }
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                Resultado = num1 - num2;
                txtResultado.Text = Resultado.ToString();
                MessageBox.Show("passou pela variavel num1", "Mensagem de acerto no try");
            }
            catch (Exception)
            {
                MessageBox.Show("aqui erro na variavel NUM", "mensagem de erro do catch");

            }

        }

        private void BTNLIMPAR_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            txtResultado.Text = "";
        }

        private void Btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            double num1, num2, Resultado;
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                Resultado = num1 * num2;
                txtResultado.Text = Resultado.ToString();
            }
            catch (Exception)
            {


            }
        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            double num1, num2, Resultado;
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                Resultado = num1 / num2;
                txtResultado.Text = Resultado.ToString();
            }
            catch (Exception)
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, Resultado;
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                Resultado = ((num1 * num2) / 100);
                txtResultado.Text = Resultado.ToString();
            }
            catch (Exception)
            {


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            int teste, teste1, teste2;

        }
    }
}
