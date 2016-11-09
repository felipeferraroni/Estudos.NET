using System;
using System.Collections;
using System.Collections.Generic;
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

        public ArrayList LerArquivoXml(string arquivo)
        {
            ArrayList elementos = new ArrayList();

            XmlTextReader xml = new XmlTextReader(arquivo);

            while (xml.Read())
            {
                switch (xml.NodeType)
                {
                    case XmlNodeType.Element:
                        if (xml.HasAttributes)
                        {
                            while (xml.MoveToNextAttribute())
                            {
                                elementos.Add(xml.Value);
                            }
                        }
                        break;
                    case XmlNodeType.Text:
                        elementos.Add(xml.Value);
                        break;
                }
            }

            return elementos;
        }

        public List<string> LerArquivoXmlEspecifico(string arquivo)
        {
            List<string> listString = new List<string>();

            //Cria uma instância de um documento XML
            XmlDocument oXML = new XmlDocument();

            //carrega o arquivo XML
            oXML.Load(arquivo);

            //Lê o filho de um Nó Pai específico
            listString.Add(oXML.SelectSingleNode("Alunos").ChildNodes[0].InnerText);
            listString.Add(oXML.SelectSingleNode("Alunos").ChildNodes[1].InnerText);
            listString.Add(oXML.SelectSingleNode("Alunos").ChildNodes[2].InnerText);

            return listString;
        }
    }
}
