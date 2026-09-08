using System;
using System.IO;

namespace ClientLab
{
    public static class GerenciadorArquivo
    {
        public static void SalvarClienteEmTxt(Pessoa cliente)
        {
            try
            {
                string nomeArquivo = cliente.Nome.Replace(" ", "_") + ".txt";

                using (StreamWriter sw = new StreamWriter(nomeArquivo))
                {
                    sw.WriteLine("========================================");
                    sw.WriteLine("         DADOS DO CLIENTE - CLIENTLAB   ");
                    sw.WriteLine("========================================");
                    sw.WriteLine($"Nome: {cliente.Nome}");
                    sw.WriteLine($"Endereço: {cliente.Logradouro}, Nº {cliente.Numero} - {cliente.Cidade} ({cliente.TipoEndereco})");

                    if (cliente is PessoaFisica pf)
                    {
                        sw.WriteLine($"Tipo: Pessoa Física");
                        sw.WriteLine($"CPF: {pf.CPF}");
                        sw.WriteLine($"Data de Nascimento: {pf.DataNascimento:dd/MM/yyyy}");
                    }
                    else if (cliente is PessoaJuridica pj)
                    {
                        sw.WriteLine($"Tipo: Pessoa Jurídica");
                        sw.WriteLine($"Razão Social: {pj.RazaoSocial}");
                        sw.WriteLine($"CNPJ: {pj.CNPJ}");
                    }

                    sw.WriteLine("========================================");
                    Console.WriteLine($"💾 Arquivo '{nomeArquivo}' gerado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Erro ao salvar o arquivo: {ex.Message}");
            }
        }
    }
}
