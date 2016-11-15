using System;
using System.IO;

namespace Basic.TrabalhandoDiretorioArquivos
{
    public class TrabalhandoDiretorios
    {
        public string DiretorioWindows(string diretorio)
        {
            string texto;
            DirectoryInfo directoryInfo = new DirectoryInfo(diretorio);

            texto = "\nInfomações do Diretorio" + Environment.NewLine;
            texto += $"Nome do Diretio: {directoryInfo.Name}" + Environment.NewLine;
            texto += $"Nome Completo Diretorio:{directoryInfo.FullName}" + Environment.NewLine;
            texto += $"Nome Completo Diretorio: {directoryInfo.Name}" + Environment.NewLine;
            texto += $"Data de Criação: {directoryInfo.CreationTime.ToString("G")}";

            return texto;
        }

        public bool DiretorioExiste(string diretorio)
        {
            return Directory.Exists(diretorio);
        }

        public void DiretorioCriar(string diretorio)
        {
            if(Directory.Exists(diretorio))
                Directory.CreateDirectory(diretorio + "\\Diretorio");
        }

        public void DiretorioDeletar(string diretorio)
        {
            if (Directory.Exists(diretorio))
            {
                Directory.Delete(diretorio);
            }
        }
    }
}
