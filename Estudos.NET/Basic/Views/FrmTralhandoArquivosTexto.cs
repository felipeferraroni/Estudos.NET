using System;
using System.Runtime.Remoting.Channels;
using Basic.Base;
using Basic.TrabalhandoArquivos;

namespace Basic.Views
{
    public sealed partial class FrmTralhandoArquivosTexto : FrmBaseView
    {
        private TrabalhandoArquivosTexto _arquivos;
        public FrmTralhandoArquivosTexto()
        {
            InitializeComponent();
            _arquivos = new TrabalhandoArquivosTexto();
            Modificatitulo("trabalha Com Arquivos");
        }

        public void Gravar(object sender, EventArgs e)
        {
            _arquivos.Criar(textBox1.Text);
        }

        public void Ler(object sender, EventArgs e)
        {
            textBox1.Text = _arquivos.Ler();
        }

        public void Limpar(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            _arquivos.Limpar();
        }
    }
}
