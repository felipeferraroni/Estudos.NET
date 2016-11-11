using System.Linq;
using System.Text.RegularExpressions;

namespace Basic.Validacao
{
    public static class Validacao
    {
        public static bool ValidaEmail(string email)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            return rg.IsMatch(email);
        }

        public static bool validCpf(string cpf)
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
            soma = temp.Select((t, i) => int.Parse(t.ToString())*(temp.Length + 1 - i)).Sum();

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

            soma = temp.Select((t, i) => int.Parse(t.ToString())*(temp.Length + 1 - i)).Sum();

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto;

            return cpf.EndsWith(digito);
        }
    }
}
