using Basic.Base;

namespace Basic.Views
{
    public partial class FrmCaixadeTexto : FrmBaseView
    {
        public FrmCaixadeTexto()
        {
            InitializeComponent();
            Modificatitulo("Caixa de Texto Padrão");
        }

        public void PreencheTexto(string texto)
        {
            textBox1.Text = texto;
        }
    }
}
