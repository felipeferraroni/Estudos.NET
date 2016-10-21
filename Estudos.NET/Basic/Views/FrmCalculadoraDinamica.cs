using System;
using System.Windows.Forms;
using Basic.Base;

namespace Basic.Views
{
    public sealed partial class FrmCalculadoraDinamica : FrmBaseView
    {
        private double total, ultimomero;
        private string operador;

        public FrmCalculadoraDinamica()
        {
            InitializeComponent();
            Modificatitulo("Calculadora Dinamica");
            Configuration();
        }

        public void CaptureButton(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                if (textBox1.Text.IndexOf(",", StringComparison.Ordinal) > 0)
                {
                    textBox1.Text += button.Text.IndexOf(",", StringComparison.Ordinal) > 0 ? string.Empty: button.Text;
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
            button16.Text = ",";
            Clear();

        }

        public void Clear()
        {
            total = 0.0;
            ultimomero = 0.0;
            operador = "+";
            textBox1.Text = String.Empty;
        }

    }
}
