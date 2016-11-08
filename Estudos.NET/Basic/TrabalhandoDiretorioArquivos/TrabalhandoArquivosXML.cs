using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Basic.TrabalhandoDiretorioArquivos
{
    public class TrabalhandoArquivosXml
    {
        public void CriarXmlFilme(string arquivo)
        {
            try
            {
                XmlTextWriter xml = new XmlTextWriter(arquivo, null);

                // Inicia documento
                xml.WriteStartDocument();

                // Indentação do arquivo
                xml.Formatting = Formatting.Indented;

                // Comenta o arquivo
                xml.WriteComment("Arquivo de filmes");

                //Inicia elemento Raiz
                xml.WriteStartElement("filmes");

                // Escreve atributo para o elemento
                xml.WriteAttributeString("ano", "2016");


                // Escreve Sub-Elementos
                xml.WriteElementString("titulo", "Jason");
                xml.WriteElementString("titulo", "Freddy");
                xml.WriteElementString("titulo", "Freddy X Jason");

                xml.WriteEndElement();
                xml.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public void CriarXmlFilme2(string arquivo)
        {
            try
            {
                XmlTextWriter xml = new XmlTextWriter(arquivo, null);

                // Inicia documento
                xml.WriteStartDocument();

                // Indentação do Arquivo
                xml.Formatting = Formatting.Indented;

                // Inicia elemento Raiz
                xml.WriteStartElement("Filmes");

                // Inicia Elemento
                xml.WriteStartElement("Filme");

                // Inclui atributo ao elemento
                xml.WriteAttributeString("Classificação", "R");

                // Inclui sub-elemento
                xml.WriteElementString("titulo", "Matrix");
                xml.WriteElementString("formato", "DVD");

                // Encerra o item
                xml.WriteEndElement();

                // Escreve Espaços entre os nós
                xml.WriteWhitespace("");

                // Escreve um segundo elemento usando um ram de dados de string
                xml.WriteRaw("<Filme>" + "<titulo>Harry Potter</titulo>" + "<formato>DVD</formato>" + "</Filme>");
                xml.WriteRaw("" + " <Filme>" + "" + " <titulo>O segredo do Dr. Hauss´s</titulo>" + "" + " <formato>CD</formato>" + "" + " </Filme>" + "");

                // Encerra elemento raiz
                xml.WriteFullEndElement();

                // Escreve o xml e encerra o editor
                xml.Close();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
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

        public DataView RetornaTabela(string arquivo)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(arquivo);
            return ds.Tables[0].DefaultView;
        }
    }
}
