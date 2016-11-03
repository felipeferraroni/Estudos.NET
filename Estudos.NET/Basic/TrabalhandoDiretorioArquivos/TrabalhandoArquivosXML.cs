using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Basic.TrabalhandoDiretorioArquivos
{
    public class TrabalhandoArquivosXml
    {
        public void CriarXmlFilme()
        {
            try
            {
                XmlTextWriter xml = new XmlTextWriter( Environment.GetFolderPath( Environment.SpecialFolder.DesktopDirectory ) + "\\Filmes.xml", null);
                xml.WriteStartDocument();
                xml.WriteStartElement("filmes");

                xml.WriteElementString("titulo", "Jason" );
                xml.WriteElementString("titulo", "Freddy" );
                xml.WriteElementString("titulo", "Freddy X Jason" );

                xml.WriteEndElement();
                xml.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string RetornaArquivo(string arquivo)
        {
            if (File.Exists(arquivo))
            {
                StreamReader ler = new StreamReader(arquivo);

                return ler.ReadToEnd();
            }

            return string.Empty;
        }
    }
}
