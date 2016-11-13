using System;
using Basic.Base;
using Basic.DataBase.DDL;

namespace Basic.Views.DDL
{
    public partial class FrmDDLCreate : FrmBaseView
    {
        private BasicDDL ddl;
        public FrmDDLCreate()
        {
            InitializeComponent();
            Modificatitulo("Banco de Dados DDL");
            ddl = new BasicDDL();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || listBox1.Items.Count > 0)
            {
                string[] list = new string[listBox1.Items.Count];
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    list[i] = listBox1.Items[i].ToString();
                }

                ddl.Create(textBox1.Text, list);
                Limpar();
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBox2.Text) || !string.IsNullOrWhiteSpace(comboBox1.Text))
            listBox1.Items.Add(string.Format("{0}  {1}", textBox2.Text.Trim(), comboBox1.Text));
        }

        public void Limpar()
        {
            textBox1.Text = string.Empty;
            textBox1.Text = string.Empty;
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = RemoveSpace(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = RemoveSpace(textBox2.Text);
        }

        private string RemoveSpace(string texto)
        {
            return texto.Replace(" ", "");
        }
    }
}
