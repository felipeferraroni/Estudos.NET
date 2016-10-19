using System;
using Basic;

namespace Application
{
    public static class Program
    {
        static Variaveis variaveis = new Variaveis();
        static InicioDosTempos inicioDosTempos = new InicioDosTempos();
        public static void Main( string[] args )
        {
            ExibeCondicoes();
            Console.ReadKey();
        }

        // Preenche Class Variaveis
        public static void ExibeVariaveis()
        {
            for (int i = 0; i < variaveis.Maximo; i++)
            {
                Console.WriteLine($"Lista - {variaveis.ListNumero[i]} - {variaveis.ListBoleano[i]} - {variaveis.ListCaracter[i]} - {variaveis.ListNumeroPreciso[i]}");
            }
        }

        public static void ExibeCondicoes()
        {
            inicioDosTempos.Condicoes();
        }
    }
}
