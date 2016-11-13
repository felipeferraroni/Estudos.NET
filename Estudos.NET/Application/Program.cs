using System;
using Basic.Functions;
using Basic.Inicio;
using Basic.TrabalhandoDiretorioArquivos;
using Basic.Views;
using Basic.Views.DDL;

namespace Application
{
    public static class Program
    {
        static Variaveis variaveis = new Variaveis();
        static InicioDosTempos inicioDosTempos = new InicioDosTempos();

        [STAThread]
        public static void Main(string[] args)
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            ExibeTelaCreateTable();
        }

        // Preenche Class Variaveis
        public static void ExibeVariaveis()
        {
            for (int i = 0; i < variaveis.Maximo; i++)
            {
                Console.WriteLine(
                    $"Lista - {variaveis.ListNumero[i]} - {variaveis.ListBoleano[i]} - {variaveis.ListCaracter[i]} - {variaveis.ListNumeroPreciso[i]}");
            }
        }

        public static void ExibeCondicoes()
        {
            inicioDosTempos.Condicoes();
        }

        public static void ExibeLoops()
        {
            inicioDosTempos.Loops();
        }

        public static void ExibeSwitch()
        {
            inicioDosTempos.Switchs();
        }

        public static void ExibeCalculos()
        {
            inicioDosTempos.Calculos();
        }

        public static void CarregaImagens()
        {
            using (var frmCarregaImagens = new FrmCarregaImagens())
            {
                frmCarregaImagens.ShowDialog();
            }
        }

        public static void CalculadoraDinamica()
        {
            using (var frmCalculadoraDinamica = new FrmCalculadoraDinamica())
            {
                frmCalculadoraDinamica.ShowDialog();
            }
        }

        public static void ExibeProgressBar()
        {
            FrmProgressBar progressBar = new FrmProgressBar();
            progressBar.ShowDialog();
        }

        public static void ExibeLogin()
        {
            var frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        public static void TrabalhandoArquivo()
        {
            FrmTralhandoArquivosTexto frmTralhando = new FrmTralhandoArquivosTexto();
            frmTralhando.ShowDialog();
        }

        public static void TrabalhandoDiretorio()
        {
            TrabalhandoDiretorios  Direct = new TrabalhandoDiretorios();

            Direct.DiretorioWindows("");
        }

        public static void LerXml()
        {
            var frm = new FrmLendoXml();
            frm.ShowDialog();
        }

        public static void TrabalhandoXml()
        {
            var frm = new FrmTranbalhandoXml();
            frm.ShowDialog();
        }

        public static void ExibeTelaCreateTable()
        {
            var frm = new FrmDDLTable();
            frm.ShowDialog();
        }
    }
}
