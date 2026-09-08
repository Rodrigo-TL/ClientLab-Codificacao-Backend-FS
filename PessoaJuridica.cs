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
                string cnpjLimpo = Regex.Replace(value, @"\D", "");
                if (cnpjLimpo.Length != 14 || cnpjLimpo.Substring(8, 4) != "0001")
                {
                    throw new ArgumentException("Erro: CNPJ inválido. Deve conter 14 dígitos numéricos e possuir '0001'.");
                }
                _cnpj = cnpjLimpo;
            }
        }

        // Etapa 2: Regra de imposto de 5% para Pessoa Jurídica
        public override double PagarImposto(double rendimento)
        {
            return rendimento * 0.05;
        }
    }
}
