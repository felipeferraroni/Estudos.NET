using System;
using System.Linq;

namespace Basic.Inicio
{
    public  class InicioDosTempos
    {
        Variaveis variaveis = new Variaveis();

        public void Calculos()
        {
            var random = new Random();
            int n1, n2, soma, sub, mult, div, resto;
            double real;

            n1 = random.Next(1, 100);
            n2 = random.Next(1, 100);
            soma = n1 + n2;
            n1 = random.Next(1, 100);
            n2 = random.Next(1, 100);
            sub = n1 - n2;
            n1 = random.Next(1, 100);
            n2 = random.Next(1, 100);
            mult = n1*n2;
            n1 = random.Next(1, 100);
            n2 = random.Next(1, 100);
            div = n1/n2;
            real = (double) n1/n2;
            resto = n1%n2;

            Console.WriteLine($"Soma {soma}, Subtração {sub}, Multiplcação {mult}, Divisao {div}, Resto {resto}, Numero Preciso(dougle) {real.ToString("0.00")}");
            Console.WriteLine();
        }

        public void Condicoes()
        {
            variaveis.Numero = 10;
            variaveis.Texto = $"Está Preenchido";

            // padrao
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

            if (variaveis.Numero == 0)
            {
                variaveis.Numero = variaveis.ArrayNumero.Length;
            }
            else if( variaveis.Numero == variaveis.ArrayNumero.Length )
            {
                variaveis.Numero = variaveis.ArrayNumero.LastOrDefault();
            }

            Console.WriteLine(variaveis.Numero);

            variaveis.Texto = variaveis.ArrayBoleano[0] ? "true" : "False";

            Console.WriteLine( variaveis.Texto.Equals("Verdadeiro") ? "Verdadeiro" : "Falso");
        }

        public void Switchs()
        {
            // O Random é muito util, quando precisamos de valores aleatorios
            Random random = new Random();

            // Atribuir a variavel um numero aleatorio de min 90 max 99
            variaveis.Numero = random.Next(90, 99);

            // Verifica a varial passada possui o valor esperado dos cases caso contrario ele usa o padrao ( default )
            switch (variaveis.Numero)
            {
                case 90:
                    Console.WriteLine($"Valor foi {variaveis.Numero}");
                    break;
                case 91:
                    Console.WriteLine( $"Valor foi {variaveis.Numero}" );
                    break;
                case 92:
                    Console.WriteLine( $"Valor foi {variaveis.Numero}" );
                    break;
                case 93:
                    Console.WriteLine( $"Valor foi {variaveis.Numero}" );
                    break;
                case 94:
                    Console.WriteLine( $"Valor foi {variaveis.Numero}" );
                    break;
                case 95:
                    Console.WriteLine( $"Valor foi {variaveis.Numero}" );
                    break;
                case 96:
                    Console.WriteLine( $"Valor foi {variaveis.Numero}" );
                    break;
                case 97:
                    Console.WriteLine( $"Valor foi {variaveis.Numero}" );
                    break;
                case 98:
                    Console.WriteLine( $"Valor foi {variaveis.Numero}" );
                    break;
                case 99:
                    Console.WriteLine( $"Valor foi {variaveis.Numero}" );
                    break;

                default:
                    Console.WriteLine( $"Valor foi {variaveis.Numero}" );
                    break;
            }
        }

        public void Loops()
        {
            variaveis.Numero = 0;
            while (variaveis.Numero < variaveis.ListNumero.Count)
            {
                variaveis.Numero++;
                Console.WriteLine($"Entrou no While - {variaveis.Numero}");
                Console.WriteLine();
            }

            do
            {
                variaveis.Numero--;
                Console.WriteLine( $"Entrou no DoWhile - {variaveis.Numero}" );
                Console.WriteLine();
            } while (variaveis.Numero > 0);

            for (int i = 0; i < variaveis.ArrayTexto.Length; i++)
            {
                Console.WriteLine(variaveis.ArrayTexto[i]);
                Console.WriteLine();
            }

            foreach (var texto in variaveis.ListTexto)
            {
                Console.WriteLine(texto);
                Console.WriteLine();
            }
        }
    }
}
