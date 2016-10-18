using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic
{
    public class Variaveis
    {
        public Variaveis()
        {

        }

        // Metodos de preenchimento de Variaveis
        public void PreencheVariaveis()
        {
            Numero = 9;
            Caracter = 'z';
            NumeroPreciso = 4.50;
            Boleano = true;
            Texto = "Tipo Texto";
            Console.WriteLine( $"Numero {Numero} Caracter {Caracter} Boleano {Boleano} Numero Preciso {NumeroPreciso} \nTexto {Texto}" );
        }

        public void PreencheVariaveis(int numero, char caracter, double numeroPreciso, bool boleano, string texto)
        {
            Numero = numero;
            Caracter = caracter;
            NumeroPreciso = numeroPreciso;
            Boleano = boleano;
            Texto = texto;
            Console.WriteLine( $"Variavel - Numero {Numero} Caracter {Caracter} Boleano {Boleano} Numero Preciso {NumeroPreciso} \nTexto {Texto}" );
        }

        // Metodos de preenchimento do Array
        public void PreencheArray()
        {
            int maximo = 10;

            ArrayNumero = new int[maximo];
            ArrayCaracter = new char[maximo];
            ArrayBoleano = new bool[maximo];
            ArrayNumeroPreciso = new double[maximo];
            ArrayTexto = new string[maximo];

            for (int i = 0; i < maximo; i++)
            {
                ArrayNumero[i] = i;
                ArrayBoleano[i] = i % 2 == 0;
                ArrayNumeroPreciso[i] = Convert.ToDouble(2 / i);
                ArrayTexto[i] = $"Array - Numero {ArrayNumero[i]} - Boelano {ArrayBoleano[i]} Double {ArrayNumeroPreciso[i]}";
                ArrayCaracter[i] = ArrayTexto[i][i];

                Console.WriteLine( $"Numero {ArrayNumero[i]} Double {ArrayNumeroPreciso[i]} Carracter {ArrayCaracter[i]} Boleano {ArrayBoleano[i]} Texto {ArrayTexto[i]}");
            }
        }

        // Metodo Preenchimento de List
        public void PreencheLista()
        {
            int maximo = 20;
            ListNumero = new List<int>();
            ListCaracter = new List<char>();
            ListBoleano = new List<bool>();
            ListNumeroPreciso = new List<double>(2);
            ListTexto = new List<string>();

            for (int i = 10; i < maximo; i++)
            {
                ListNumero.Add(i);
                ListNumeroPreciso.Add(Convert.ToDouble( i / 2));
                ListBoleano.Add(i % 2 ==0);
                ListTexto.Add($"Array - Numero {ListNumero[i]} - Boelano {ListBoleano[i]} Double {ListNumeroPreciso[i]}");
                ListCaracter.Add(ListTexto[i][i]);

                Console.WriteLine( $"Numero {ListNumero[i]} Double {ListNumeroPreciso[i]} Carracter {ListCaracter[i]} Boleano {ListBoleano[i]} Texto {ListTexto[i]}" );
            }
        }

        // Variaves
        public int Numero { get; set; }
        public string Texto { get; set; }
        public char Caracter { get; set; }
        public double NumeroPreciso { get; set; }
        public bool Boleano { get; set; }

        // Vetores
        public int[] ArrayNumero { get; set; }
        public string[] ArrayTexto { get; set; }
        public char[] ArrayCaracter { get; set; }
        public double[] ArrayNumeroPreciso { get; set; }
        public bool[] ArrayBoleano { get; set; }

        // Listas
        public List<int> ListNumero { get; set; }
        public List<string> ListTexto { get; set; }
        public List<char> ListCaracter { get; set; }
        public List<double> ListNumeroPreciso { get; set; }
        public List<bool> ListBoleano { get; set; }
    }
}
