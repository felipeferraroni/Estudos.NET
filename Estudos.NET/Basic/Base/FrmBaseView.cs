using System.Windows.Forms;

namespace Basic.Base
{
    public partial class FrmBaseView : Form
    {
        public FrmBaseView()
        {
            InitializeComponent();
        }

        public virtual void Modificatitulo(string titulo)
        {
            lblTitulo.Text = titulo;
        }
    }
}
