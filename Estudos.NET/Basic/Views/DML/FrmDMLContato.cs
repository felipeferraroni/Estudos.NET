using System;
using Basic.Base;
using Basic.DataBase.DML;
using Basic.Functions;

namespace Basic.Views.DML
{
    public partial class FrmDMLContato : FrmBaseView
    {
        BasicDML dml = new BasicDML();
        public FrmDMLContato()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(maskedTextBox1.Text.Replace("/", "").Replace("_","")))
            {
                dml.InsertContato(textBox1.Text, maskedTextBox1.Text.ToDateTime());
                Close();
            }
        }
    }
}
