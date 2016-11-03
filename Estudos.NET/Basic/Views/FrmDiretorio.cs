using System.Windows.Forms;
using Basic.Base;
using Basic.TrabalhandoDiretorioArquivos;

namespace Basic.Views
{
    public partial class FrmDiretorio : FrmCaixadeTexto
    {
        private TrabalhandoDiretorios _diretorios;

        public FrmDiretorio()
        {
            InitializeComponent();
            _diretorios = new TrabalhandoDiretorios();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var browserDialog = new FolderBrowserDialog();
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                _diretorios.DiretorioCriar(browserDialog.SelectedPath);
                textBox1.Text = browserDialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            var browserDialog = new FolderBrowserDialog();
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = _diretorios.DiretorioWindows(browserDialog.SelectedPath);
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            var browserDialog = new FolderBrowserDialog();
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                _diretorios.DiretorioDeletar(browserDialog.SelectedPath);
                textBox1.Text = browserDialog.SelectedPath + "DiretorioCriado";
            }
        }
    }
}
