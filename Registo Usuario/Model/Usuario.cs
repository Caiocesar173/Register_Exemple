using System;

namespace Registo_Usuario.Model
{
    class Usuario
    {
        private string nome;
        private string enderço;
        private string cpf;
              

        public string Nome { get => nome; set => nome = value; }
        public string Enderço { get => enderço; set => enderço = value; }
        public string CPF { get => cpf; set => cpf = value; }
       

        public bool ValidaCPF(string cpf)
        {
            string tempCpf;
            string digito;
            int soma;
            int resto;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            

            if(cpf.Contains(".") || cpf.Contains("-"))
            {
                cpf = cpf.Trim();
                if (cpf.Contains("."))
                {
                    cpf = cpf.Replace(".", "");
                }
                if (cpf.Contains("-"))
                {
                    cpf = cpf.Replace("-", "");
                }
            }

            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }
    }
}
