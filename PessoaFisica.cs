using System;

namespace ClientLab
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; } = string.Empty;
        private DateTime _dataNascimento;

        public DateTime DataNascimento
        {
            get => _dataNascimento;
            set
            {
                if (CalcularIdade(value) < 18)
                {
                    throw new ArgumentException("Erro: Apenas pessoas com idade igual ou superior a 18 anos podem ser cadastradas.");
                }
                _dataNascimento = value;
            }
        }

        private int CalcularIdade(DateTime dataNasc)
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - dataNasc.Year;
            
            // Ajusta a idade se o aniversário ainda não aconteceu este ano
            if (dataNasc.Date > hoje.AddYears(-idade)) 
                idade--;
                
            return idade;
        }
    }
}
