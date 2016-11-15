using System;
using System.Windows.Forms;

namespace Basic.Views
{
    public partial class FrmProgressBar : Form
    {
        public FrmProgressBar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                Close();
            }
        }
    }
}
