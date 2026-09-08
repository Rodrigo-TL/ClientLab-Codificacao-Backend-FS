using System;

namespace ClientLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Testando Sistema ClientLab (Parte 3 - Arquivos) --- \n");

            try
            {
                PessoaFisica pf = new PessoaFisica
                {
                    Nome = "Aline Souzza",
                    CPF = "123.456.789-11",
                    DataNascimento = new DateTime(1998, 10, 15),
                    Logradouro = "Rua das Flores",
                    Numero = "123",
                    Cidade = "Brasília",
                    TipoEndereco = "Residencial"
                };

                Console.WriteLine($"Cadastrando {pf.Nome}...");
                GerenciadorArquivo.SalvarClienteEmTxt(pf);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Erro PF: {ex.Message}\n");
            }

            Console.WriteLine("--------------------------------------------------\n");

            try
            {
                PessoaJuridica pj = new PessoaJuridica
                {
                    Nome = "ClientLab Tech",
                    RazaoSocial = "ClientLab Solucoes LTDA",
                    CNPJ = "99.888.777/0001-55",
                    Logradouro = "Setor de Industrias Graficas",
                    Numero = "S/N",
                    Cidade = "Brasília",
                    TipoEndereco = "Comercial"
                };

                Console.WriteLine($"Cadastrando {pj.Nome}...");
                GerenciadorArquivo.SalvarClienteEmTxt(pj);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Erro PJ: {ex.Message}\n");
            }
        }
    }
}
