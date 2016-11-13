using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Basic.Functions
{
    public static class Functions
    {
        /// <summary>
        /// Verifica se o e-mail é valido.
        /// </summary>
        /// <param name="email">
        /// Parâmetro email requer angrumento tipo string
        /// </param>
        /// <returns>
        /// Retorna valor Boleano
        /// </returns>
        public static bool Email(string email)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            return rg.IsMatch(email);
        }

        /// <summary>
        /// Verifica se o cpf é valido.
        /// </summary>
        /// <param name="cpf">
        /// Parâmetro cpf requer angrumento tipo string
        /// </param>
        /// <returns>
        /// Retorna valor Boleano
        /// </returns>
        public static bool Cpf(string cpf)
        {
            int soma, resto;
            string temp, digito;

            // Remove espaço ponto e traço
            cpf = cpf.Trim().Replace(".", "").Replace("-", "");

            // Necessário 11 caracteres
            if (cpf.Length < 11)
                return false;

            // Insere 9 caracteres no temporario
            temp = cpf.Substring(0, 9);

            // Soma os 9 caraceres utiulizando expressao Lambda
            soma = temp.Select((t, i) => int.Parse(t.ToString()) * (temp.Length + 1 - i)).Sum();

            // pega o resto da divisao
            resto = soma % 11;

            // verifica se é menor que dois para atribuir o valor 0 senao e 11 - resto
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            // Inseri o digito
            digito = resto.ToString();

            // Adiciona o digito ao temp
            temp = temp + digito;

            soma = temp.Select((t, i) => int.Parse(t.ToString()) * (temp.Length + 1 - i)).Sum();

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto;

            return cpf.EndsWith(digito);
        }

        /// <summary>
        /// Verifica se o cnpj é valido.
        /// </summary>
        /// <param name="cnpj">
        /// Parâmetro cnpj requer angrumento tipo string
        /// </param>
        /// <returns>
        /// Retorna valor Boleano
        /// </returns>
        public static bool Cnpj(string cnpj)
        {
            int[] multiplicador = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma, resto;
            string digito, temp;

            // Remove outros caracteres
            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

            // Verifica se possui 14 caracteres
            if (cnpj.Length < 14)
                return false;

            // Coloca o cnoj na variavel temporaria
            temp = cnpj.Substring(0, 12);

            // Soma os Valores da variavel temporaria
            soma = temp.Select((t, i) => int.Parse(t.ToString()) * multiplicador[i + 1]).Sum();

            // pega o resto da soma
            resto = (soma % 11);

            // se o resto for menor que 2 entao resto é zero caso contratio 11 - resto
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            // Atribui o digito
            digito = resto.ToString();

            // Adiciona o digito ao temp
            temp = temp + digito;

            // Soma os Valores da variavel temporaria
            soma = temp.Select((t, i) => int.Parse(t.ToString()) * multiplicador[i]).Sum();

            // pega o resto da soma
            resto = (soma % 11);

            // se o resto for menor que 2 entao resto é zero caso contratio 11 - resto
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            // Adiciona o digito ao temp
            digito = digito + resto;

            // Verifica se é valido
            return cnpj.EndsWith(digito);
        }

        /// <summary>
        /// Convert o valor em inteiro
        /// </summary>
        /// <param name="obj">
        /// Argumento do Tipo obj
        /// </param>
        /// <returns>
        /// Retorna um inteiro
        /// </returns>
        public static int ToInt(this object obj) => !string.IsNullOrWhiteSpace(obj?.ToString()) ? int.Parse(obj.ToString()) : 0;

        /// <summary>
        /// Convert o valor em double
        /// </summary>
        /// <param name="obj">
        /// Argumento do Tipo obj
        /// </param>
        /// <returns>
        /// Retorna um double
        /// </returns>
        public static double ToDouble(this object obj) => !string.IsNullOrWhiteSpace(obj.ToString()) ? double.Parse(obj.ToString()) : 0;

        /// <summary>
        /// Convert o valor em float
        /// </summary>
        /// <param name="obj">
        /// Argumento do Tipo obj
        /// </param>
        /// <returns>
        /// Retorna um float
        /// </returns>
        public static float ToFloat(this object obj) => !string.IsNullOrWhiteSpace(obj?.ToString()) ? float.Parse(obj.ToString()) : 0;

        /// <summary>
        /// Convert o valor em boleano
        /// </summary>
        /// <param name="obj">
        /// Argumento do Tipo obj
        /// </param>
        /// <returns>
        /// Retorna um boleano
        /// </returns>
        public static bool ToBoolean(this object obj) => !string.IsNullOrWhiteSpace(obj?.ToString()) && bool.Parse(obj.ToString());

        /// <summary>
        /// Verifica se o datatable contem linhas.
        /// </summary>
        /// <param name="dt">
        /// Parâmetro dt requer angrumento tipo DataTable
        /// </param>
        public static bool HasRows(this DataTable dt) => dt != null && dt.Rows.Count > 0;

        /// <summary>
        /// Returna primeira linha do Datatable
        /// </summary>
        /// <param name="dt">
        /// Argumento do Tipo Datatable
        /// </param>
        /// <returns>
        /// Retorna um Datarow
        /// </returns>

        public static DataRow First(this DataTable dt) => dt.HasRows() ? dt.Rows[0] : null;

        /// <summary>
        /// Formata data para Data table
        /// </summary>
        /// <param name="date">
        /// Argumento do Tipo DateTime
        /// </param>
        /// <returns>
        /// Retorna uma string
        /// </returns>
        public static string ToFormatDataTable(this DateTime date) => date.ToString("#yyyyMMddhhmmss#");

        /// <summary>
        /// Verifica se o Array de DataRow está preenchido
        /// </summary>
        /// <param name="drs">
        /// Parâmetro Drs requer angrumento tipo Array de Rows
        /// </param>
        /// <returns>
        /// Retorna valor Boleano
        /// </returns>
        public static bool HasRows(this DataRow[] drs) => drs != null && drs.Length > 0;

        /// <summary>
        /// Returna primeira linha do Array da Rows
        /// </summary>
        /// <param name="drs">
        /// Argumento do Tipo Array de Rows
        /// </param>
        /// <returns>
        /// Retorna um Datarow
        /// </returns>
        public static DataRow First(this DataRow[] drs) => drs.HasRows() ? drs[0] : null;

        /// <summary>
        /// Retorna Ultimo dia do mes
        /// </summary>
        /// <param name="date">
        /// Argumento do Tipo Datetime
        /// </param>
        /// <returns>
        /// Retorna um DateTime
        /// </returns>
        public static DateTime LastDayMonth(this DateTime date) => new DateTime(date.Year, date.Month,1).AddMonths(1).AddDays(-1);

        /// <summary>
        /// Retorna Primeiro dia do mes
        /// </summary>
        /// <param name="date">
        /// Argumento do Tipo Datetime
        /// </param>
        /// <returns>
        /// Retorna um DateTime
        /// </returns>
        public static DateTime FirstDayMonth(this DateTime date) => new DateTime(date.Year, date.Month,1);

        /// <summary>
        /// Convert string em Data
        /// </summary>
        /// <param name="obj">
        /// Argumento do Tipo Objeto
        /// </param>
        /// <returns>
        /// Retorna um DateTime
        /// </returns>
        public static DateTime ToDateTime(this object obj) => !string.IsNullOrWhiteSpace(obj.ToString()) ? DateTime.Parse(obj.ToString()) : DateTime.MinValue;

        /// <summary>
        /// Retorna uma string criptografada
        /// </summary>
        /// <param name="password">
        /// Argumento do Tipo Datetime
        /// </param>
        /// <returns>
        /// Retorna uma string criptografada
        /// </returns>
        public static string EncryptSha256(this string password)
        {
            string hash = string.Empty;
            var crypt  = new SHA256Managed();
            var crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(password), 0,
                Encoding.ASCII.GetByteCount(password));
            return crypto.Aggregate(hash, (current, crpt) => current + crpt.ToString("X2"));
        }


    }

}
