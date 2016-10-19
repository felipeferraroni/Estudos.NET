using System;

namespace Basic
{
    public  class InicioDosTempos
    {
        Variaveis variaveis = new Variaveis();

        public void Condicoes()
        {
            variaveis.Numero = 10;
            variaveis.Texto = $"Está Preenchido";
            if (variaveis.Numero == 10)
            {
                Console.WriteLine($"Verdadeiro: 10 Igual {variaveis.Numero}");
            }
            else
            {
                Console.WriteLine( $"False: 10 Difente {variaveis.Numero}" );
            }

            if (string.IsNullOrWhiteSpace(variaveis.Texto))
            {
                Console.WriteLine($"Verdadeiro: Variavel é nula = {variaveis.Texto}");
            }
            else
            {
                Console.WriteLine( $"False: Variavel Não é nula = {variaveis.Texto}" );
            }
        }
    }
}
