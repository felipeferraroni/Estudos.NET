using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Basic.Base;
using Basic.TrabalhandoDiretorioArquivos;

namespace Basic.Views
{
    public partial class FrmTranbalhandoXml : FrmCaixadeTexto
    {
        private TrabalhandoArquivosXml _trabalhandoXml;
        public FrmTranbalhandoXml()
        {
            InitializeComponent();
            _trabalhandoXml = new TrabalhandoArquivosXml();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arquivo = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Filmes.xml";
            if (File.Exists(arquivo))
            {
                File.Delete(arquivo);
            }
            _trabalhandoXml.CriarXmlFilme();

            textBox1.Text = _trabalhandoXml.RetornaArquivo(arquivo);
        }
    }
}
