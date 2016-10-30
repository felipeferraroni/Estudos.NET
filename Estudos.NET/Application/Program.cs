﻿using System;
using Basic;
using Basic.Views;

namespace Application
{
    public static class Program
    {
        static Variaveis variaveis = new Variaveis();
        static InicioDosTempos inicioDosTempos = new InicioDosTempos();

        [STAThread]
        public static void Main(string[] args)
        {
            FrmProgressBar progressBar = new FrmProgressBar();
            progressBar.ShowDialog();
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
    }
}
