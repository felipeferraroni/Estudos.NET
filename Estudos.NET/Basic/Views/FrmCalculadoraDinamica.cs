using System;
using System.Globalization;
using System.Windows.Forms;
using Basic.Base;

namespace Basic.Views
{
    public sealed partial class FrmCalculadoraDinamica : FrmBaseView
    {
        private double total, primeiroNumero ,ultimoNumero;
        private string operador;

        public FrmCalculadoraDinamica()
        {
            InitializeComponent();
            Modificatitulo("Calculadora Dinamica");
            Configuration();
        }

        public void Calculator(object sender, EventArgs e)
        {
            ultimoNumero = Convert.ToDouble(textBox1.Text.Replace($"{primeiroNumero}{operador}", ""));
            #region Swtch

            switch (operador)
            {
                case "+":
                    total = primeiroNumero + ultimoNumero;
                    break;
                case "-":
                    total = primeiroNumero - ultimoNumero;
                    break;
                case "*":
                    total = primeiroNumero * ultimoNumero;
                    break;
                case "/":
                    total = primeiroNumero / ultimoNumero;
                    break;
            }
            #endregion

            textBox1.Text = $"{total}";

            AlterButton(false);
        }

        public void AlterButton(bool enable)
        {
            button0.Enabled = enable;
            button1.Enabled = enable;
            button2.Enabled = enable;
            button3.Enabled = enable;
            button4.Enabled = enable;
            button5.Enabled = enable;
            button6.Enabled = enable;
            button9.Enabled = enable;
            button8.Enabled = enable;
            button7.Enabled = enable;
            button10.Enabled = enable;
            button11.Enabled = enable;
            button12.Enabled = enable;
            button13.Enabled = enable;
            button14.Enabled = enable;
        }

        public void Operacao(object sender, EventArgs e)
        {
            primeiroNumero = Convert.ToDouble(textBox1.Text);
            var button = sender as Button;
            if (button != null)
            {
                operador = button.Text;
                textBox1.Text += operador;
            }
        }

        public void CaptureButton(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                if (textBox1.Text.Contains(","))
                {
                    textBox1.Text += button.Text.Contains(",") ? string.Empty: button.Text;
                }
                else
                {
                    textBox1.Text += button.Text;
                }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Configuration()
        {
            textBox1.ReadOnly = true;
            button0.Text = "0";
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "6";
            button5.Text = "5";
            button6.Text = "4";
            button9.Text = "7";
            button8.Text = "8";
            button7.Text = "9";
            button10.Text = "*";
            button11.Text = "-";
            button12.Text = "+";
            button13.Text = "/";
            button14.Text = "=";
            button15.Text = "Limpar";
            Clear();

        }

        public void Clear()
        {
            total = 0.0;
            ultimoNumero = 0.0;
            primeiroNumero = 0.0;
            operador = String.Empty;
            textBox1.Text = String.Empty;
            AlterButton(true);
        }

    }
}
