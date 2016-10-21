using System;
using System.Windows.Forms;
using Basic.Base;

namespace Basic.Views
{
    public partial class FrmCarregaImagens : FrmBaseView
    {
        public FrmCarregaImagens()
        {
            InitializeComponent();
        }

        private void FrmCarregaImagens_Load(object sender, System.EventArgs e)
        {
            Modificatitulo("Carrega Imagens");
        }

        private void btnOpen_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                txtPath.Text = openFileDialog.SafeFileName;
                pcbPicture.ImageLocation = openFileDialog.FileName;
            }

        }
    }
}
