using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float calcularmedia(float n1, float n2, float n3, float p1, float p2, float p3)
        {
            float media = (n1 * p1 + n2 * p2 + p3 * n3) / (p1 + p2 + p3);
            return media;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            float n1 = Convert.ToSingle(textBox1.Text);
            float n2 = Convert.ToSingle(textBox2.Text);
            float n3 = Convert.ToSingle(textBox3.Text);
            float p1 = Convert.ToSingle(textBox1.Text);
            float p2 = Convert.ToSingle(textBox2.Text);
            float p3 = Convert.ToSingle(textBox3.Text);
            float resultado = calcularmedia(n1, n2, n3, p1, p2, p3);
            MessageBox.Show("Nota final: " + resultado.ToString());
        }

        float soma_quad(float valor1, float valor2, float valor3)
        {
            float quadrado = ((valor1 * valor1) + (valor2 * valor2) + (valor3 * valor3));
            return quadrado;

        }
                float calculararitmetica(float n1, float n2, float n3)
        {
            float aritmetica = (n1 + n2 + n3) / (3);
            return aritmetica;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float valor1 = Convert.ToSingle(textBox1.Text);
            float valor2 = Convert.ToSingle(textBox2.Text);
            float valor3 = Convert.ToSingle(textBox3.Text);
            float som = soma_quad(valor1, valor2, valor3);
            MessageBox.Show("Soma Quadrado: " + som.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float n1 = Convert.ToSingle(textBox1.Text);
            float n2 = Convert.ToSingle(textBox2.Text);
            float n3 = Convert.ToSingle(textBox3.Text);
            float resultado = calculararitmetica(n1, n2, n3);
            MessageBox.Show("Nota final: " + resultado.ToString());
        }
    }
}
