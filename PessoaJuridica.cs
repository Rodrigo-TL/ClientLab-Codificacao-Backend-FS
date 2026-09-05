using System;
using System.Text.RegularExpressions;

namespace ClientLab
{
    public class PessoaJuridica : Pessoa
    {
        public string RazaoSocial { get; set; } = string.Empty;
        private string _cnpj = string.Empty;

        public string CNPJ
        {
            get => _cnpj;
            set
            {
                // Remove qualquer caractere que não seja número (pontos, barras, traços)
                string cnpjLimpo = Regex.Replace(value, @"\D", "");

                // Valida se tem exatamente 14 dígitos e se os 4 antepenúltimos (índices 8 a 11) são "0001"
                if (cnpjLimpo.Length != 14 || cnpjLimpo.Substring(8, 4) != "0001")
                {
                    throw new ArgumentException("Erro: CNPJ inválido. Deve conter 14 dígitos numéricos e possuir '0001' antes dos dígitos verificadores.");
                }
                _cnpj = cnpjLimpo;
            }
        }
    }
}
