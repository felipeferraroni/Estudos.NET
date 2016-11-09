using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Basic.Base;
using Basic.TrabalhandoDiretorioArquivos;

namespace Basic.Views
{
    public partial class FrmLendoXml : FrmBaseView
    {
        private readonly TrabalhandoArquivosXml _trabalhandoArquivosXml;
        public FrmLendoXml()
        {
            InitializeComponent();
            _trabalhandoArquivosXml = new TrabalhandoArquivosXml();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string arquivo;
            ArrayList arrayList;
            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                Filter = "XML Files (*.xml)|*.xml",
                FilterIndex = 2,
                DefaultExt = "xml",
                RestoreDirectory = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                arquivo = dialog.FileName;
                textBox1.Text = arquivo;
                arrayList = _trabalhandoArquivosXml.LerArquivoXml(arquivo);

                foreach (var list in arrayList)
                {
                    listBox1.Items.Add(list);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string arquivo;
            List<string> listString;
            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                Filter = "XML Files (*.xml)|*.xml",
                FilterIndex = 2,
                DefaultExt = "xml",
                RestoreDirectory = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                arquivo = dialog.FileName;
                textBox1.Text = arquivo;
                listString = _trabalhandoArquivosXml.LerArquivoXmlEspecifico(arquivo);

                foreach (var list in listString)
                {
                    listBox1.Items.Add(list);
                }
            }
        }
    }
}
