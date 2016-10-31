using System;
using System.Xml;
using Basic.Base;

namespace Basic.Views
{
    public partial class FrmLogin : FrmBaseView
    {
        public FrmLogin()
        {
            InitializeComponent();
            Modificatitulo("Tela de " + Name.Replace("Frm", ""));
        }

        public void GeraXML()
        {
            try
            {
                XmlTextWriter xml = new XmlTextWriter("Login.XML", null);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
