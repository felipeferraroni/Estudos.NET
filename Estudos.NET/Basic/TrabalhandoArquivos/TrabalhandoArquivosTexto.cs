using System.IO;

namespace Basic.TrabalhandoArquivos
{
    public class TrabalhandoArquivosTexto
    {

        public void Criar(string texto)
        {
            using (StreamWriter escrever = new StreamWriter("ArquivoDeTexto.txt", true))
            {
                escrever.WriteLine(texto);
            }

            using (StreamWriter escrever = new StreamWriter("ArquivoDeTexto.txt", true))
            {
                escrever.WriteLine("\nRóda pé\n");
            }
        }

        public string Ler()
        {
            using (StreamReader ler = new StreamReader("ArquivoDeTexto.txt"))
            {
                string lido = string.Empty, lendo = string.Empty;

                return ler.ReadToEnd();
            }
        }

        public void Limpar()
        {
            using (StreamWriter limpar = new StreamWriter("ArquivoDeTexto.txt"))
            {
                limpar.WriteLine(string.Empty);
            }
        }
    }
}

