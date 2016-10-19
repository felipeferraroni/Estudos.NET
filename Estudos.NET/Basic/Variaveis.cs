using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic
{
    public class Variaveis
    {
        public Variaveis()
        {
            Maximo = 10;
            PreencheVariaveis();
            PreencheArray();
            PreencheLista();
        }

        // Metodos de preenchimento de Variaveis
        public void PreencheVariaveis()
        {
            Numero = 9;
            Caracter = 'z';
            NumeroPreciso = 4.50;
            Boleano = true;
            Texto = "Tipo Texto";
        }

        public void PreencheVariaveis(int numero, char caracter, double numeroPreciso, bool boleano, string texto)
        {
            Numero = numero;
            Caracter = caracter;
            NumeroPreciso = numeroPreciso;
            Boleano = boleano;
            Texto = texto;
        }

        // Metodos de preenchimento do Array
        public void PreencheArray()
        {
            ArrayNumero = new int[Maximo];
            ArrayCaracter = new char[Maximo];
            ArrayBoleano = new bool[Maximo];
            ArrayNumeroPreciso = new double[Maximo];
            ArrayTexto = new string[Maximo];

            for (int i = 0; i < Maximo; i++)
            {
                ArrayNumero[i] = i;
                ArrayBoleano[i] = i % 2 == 0;
                ArrayNumeroPreciso[i] = (double)i / 2;
                ArrayTexto[i] = $"Array - Numero {ArrayNumero[i]} - Boelano {ArrayBoleano[i]} Double {ArrayNumeroPreciso[i]}";
                ArrayCaracter[i] = ArrayTexto[i][i];
            }
        }

        // Metodo Preenchimento de List
        public void PreencheLista()
        {
            ListNumero = new List<int>();
            ListCaracter = new List<char>();
            ListBoleano = new List<bool>();
            ListNumeroPreciso = new List<double>(2);
            ListTexto = new List<string>();

            for (int i = 0; i < Maximo; i++)
            {
                ListNumero.Add(i);
                ListNumeroPreciso.Add( (double) i / 2);
                ListBoleano.Add(i % 2 ==0);
                ListTexto.Add($"List - Numero {ListNumero[i]} - Boelano {ListBoleano[i]} Double {ListNumeroPreciso[i]}");
                ListCaracter.Add(ListTexto[i][i]);
            }
        }

        // Apenas para limitar
        public int Maximo { get; set; }
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
