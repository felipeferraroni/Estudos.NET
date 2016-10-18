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
            Console.WriteLine( $"Numero {Numero} Caracter {Caracter} Boleano {Boleano} Numero Preciso {NumeroPreciso} \nTexto {Texto}" );
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
                ArrayTexto[i] = $"Numero {ArrayNumero[i]} - Boelano {ArrayBoleano[i]} Double {ArrayNumeroPreciso[i]}";
                ArrayCaracter[i] = Convert.ToChar(ArrayTexto[i].Substring(i));

                Console.WriteLine( $"Numero {ArrayNumero[i]} Double {ArrayNumeroPreciso} Carracter {ArrayCaracter} Boleano {ArrayBoleano[i]} Texto {ArrayTexto[i]}");
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
