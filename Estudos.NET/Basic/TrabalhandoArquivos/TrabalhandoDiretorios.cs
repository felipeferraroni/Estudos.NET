using System;
using System.IO;
using Basic.Views;

namespace Basic.TrabalhandoArquivos
{
    public class TrabalhandoDiretorios
    {
        public void DiretorioWindows()
        {
            string texto;
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Windows\System32");

            texto = string.Format("\nInfomações do Diretorio\n");
            texto += $"Nome do Diretio: {directoryInfo.Name} ";
            texto += $"Nome Completo Diretio:{directoryInfo.FullName}";
            texto += $"Nome Completo Diretio: {directoryInfo.Name} ";
            directoryInfo.CreationTime.ToString("G");

            FrmCaixadeTexto frm = new FrmCaixadeTexto();
            frm.PreencheTexto(texto);
            frm.ShowDialog();


        }
    }
}
