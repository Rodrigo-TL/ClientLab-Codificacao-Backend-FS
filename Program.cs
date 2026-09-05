using System;

namespace ClientLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Testando Sistema ClientLab --- \n");

            // 1. Testando Pessoa Física Válida (Maior de 18 anos)
            try
            {
                PessoaFisica pfValida = new PessoaFisica();
                pfValida.Nome = "João Silva";
                pfValida.CPF = "123.456.789-00";
                pfValida.DataNascimento = new DateTime(2000, 05, 20); // Nasceu em 2000, tem mais de 18 anos
                Console.WriteLine($"✅ PF Cadastrada com sucesso: {pfValida.Nome}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // 2. Testando Pessoa Física Inválida (Menor de 18 anos)
            try
            {
                PessoaFisica pfInvalida = new PessoaFisica();
                pfInvalida.Nome = "Lucas Menor";
                pfInvalida.DataNascimento = DateTime.Today.AddYears(-15); // Forçando 15 anos de idade
                Console.WriteLine($"✅ PF Cadastrada com sucesso: {pfInvalida.Nome}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ {ex.Message}");
            }

            Console.WriteLine("\n-----------------------------------\n");

            // 3. Testando Pessoa Jurídica Válida (Com miolo 0001)
            try
            {
                PessoaJuridica pjValida = new PessoaJuridica();
                pjValida.Nome = "Mercado Tech";
                pjValida.RazaoSocial = "Mercado Tech LTDA";
                pjValida.CNPJ = "12.345.678/0001-95"; // Contém o padrão '0001'
                Console.WriteLine($"✅ PJ Cadastrada com sucesso: {pjValida.RazaoSocial}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // 4. Testando Pessoa Jurídica Inválida (Sem o miolo 0001)
            try
            {
                PessoaJuridica pjInvalida = new PessoaJuridica();
                pjInvalida.RazaoSocial = "Empresa Errada";
                pjInvalida.CNPJ = "12.345.678/0002-95"; // Errado, colocou '0002'
                Console.WriteLine($"✅ PJ Cadastrada com sucesso: {pjInvalida.RazaoSocial}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ {ex.Message}");
            }
        }
    }
}
