using System;
using System.Diagnostics.PerformanceData;
using Basic;

namespace Application
{
    public static class Program
    {
        static Variaveis variaveis = new Variaveis();
        static InicioDosTempos inicioDosTempos = new InicioDosTempos();
        public static void Main( string[] args )
        {
            ExibeCalculos();
            Console.ReadKey();
        }

        // Preenche Class Variaveis
        public static void ExibeVariaveis()
        {
            for ( int i = 0; i < variaveis.Maximo; i++ )
            {
                Console.WriteLine( $"Lista - {variaveis.ListNumero[i]} - {variaveis.ListBoleano[i]} - {variaveis.ListCaracter[i]} - {variaveis.ListNumeroPreciso[i]}" );
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
    }
}
