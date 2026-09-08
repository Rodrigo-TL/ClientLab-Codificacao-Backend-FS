using System;

namespace ClientLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Testando Sistema ClientLab (Parte 2) --- \n");

            // 1. Teste de Pessoa Física com Endereço e Imposto (3%)
            try
            {
                PessoaFisica pf = new PessoaFisica();
                pf.Nome = "Aline Souzza";
                pf.CPF = "123.456.789-11";
                pf.DataNascimento = new DateTime(1998, 10, 15);
                
                // Preenchendo Endereço (Etapa 3)
                pf.Logradouro = "Rua das Flores";
                pf.Numero = "123";
                pf.Cidade = "Brasília";
                pf.TipoEndereco = "Residencial";

                double rendimentoPF = 3000.00;
                double impostoPF = pf.PagarImposto(rendimentoPF);

                Console.WriteLine($"✅ PF Cadastrada: {pf.Nome}");
                Console.WriteLine($"   Endereço: {pf.Logradouro}, Nº {pf.Numero} - {pf.Cidade} ({pf.TipoEndereco})");
                Console.WriteLine($"   Rendimento: R$ {rendimentoPF:F2} | Imposto (3%): R$ {impostoPF:F2}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Erro PF: {ex.Message}\n");
            }

            Console.WriteLine("--------------------------------------------------\n");

            // 2. Teste de Pessoa Jurídica com Endereço e Imposto (5%)
            try
            {
                PessoaJuridica pj = new PessoaJuridica();
                pj.Nome = "ClientLab Tech";
                pj.RazaoSocial = "ClientLab Soluções LTDA";
                pj.CNPJ = "99.888.777/0001-55";

                // Preenchendo Endereço (Etapa 4)
                pj.Logradouro = "Setor de Indústrias Gráficas";
                pj.Numero = "S/N";
                pj.Cidade = "Brasília";
                pj.TipoEndereco = "Comercial";

                double rendimentoPJ = 50000.00;
                double impostoPJ = pj.PagarImposto(rendimentoPJ);

                Console.WriteLine($"✅ PJ Cadastrada: {pj.RazaoSocial}");
                Console.WriteLine($"   Endereço: {pj.Logradouro}, Nº {pj.Numero} - {pj.Cidade} ({pj.TipoEndereco})");
                Console.WriteLine($"   Rendimento: R$ {rendimentoPJ:F2} | Imposto (5%): R$ {impostoPJ:F2}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Erro PJ: {ex.Message}\n");
            }
        }
    }
}
