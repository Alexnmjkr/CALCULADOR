using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CALCULADOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double LeerNumero(System.Windows.Forms.TextBox textBox)
        {
            if (double.TryParse(textBox.Text, out double numero))
                return numero;

            MessageBox.Show("Ingrese un número válido");
            return 0;
        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNumero1.Text) || string.IsNullOrWhiteSpace(textBoxNumero2.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos");
                return;
            }

            double a = LeerNumero(textBoxNumero1);
            double b = LeerNumero(textBoxNumero2);
            labelResultado.Text = "Resultado: " + (a + b);
        }

        private void buttonRestar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNumero1.Text) || string.IsNullOrWhiteSpace(textBoxNumero2.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos");
                return;
            }

            double a = LeerNumero(textBoxNumero1);
            double b = LeerNumero(textBoxNumero2);
            labelResultado.Text = "Resultado: " + (a - b);
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNumero1.Text) || string.IsNullOrWhiteSpace(textBoxNumero2.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos");
                return;
            }

            double a = LeerNumero(textBoxNumero1);
            double b = LeerNumero(textBoxNumero2);
            labelResultado.Text = "Resultado: " + (a * b);
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNumero1.Text) || string.IsNullOrWhiteSpace(textBoxNumero2.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos");
                return;
            }

            double a = LeerNumero(textBoxNumero1);
            double b = LeerNumero(textBoxNumero2);

            if (b == 0)
            {
                MessageBox.Show("No se puede dividir entre cero");
                return;
            }

            labelResultado.Text = "Resultado: " + (a / b);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNumero1.Clear();
            textBoxNumero2.Clear();
            labelResultado.Text = "0";
        }
    }
}