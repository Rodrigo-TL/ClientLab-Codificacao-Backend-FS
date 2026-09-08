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
                // Substitui espaços por underline para evitar problemas no nome do arquivo
                // Exemplo: "Aline Souzza" vira "Aline_Souzza.txt"
                string nomeArquivo = cliente.Nome.Replace(" ", "_") + ".txt";

                // Abre o arquivo para escrita (se não existir, ele cria; se existir, ele substitui)
                using (StreamWriter sw = new StreamWriter(nomeArquivo))
                {
                    sw.WriteLine("========================================");
                    sw.WriteLine("         DADOS DO CLIENTE - CLIENTLAB   ");
                    sw.WriteLine("========================================");
                    sw.WriteLine($"Nome: {cliente.Nome}");
                    sw.WriteLine($"Endereço: {cliente.Logradouro}, Nº {cliente.Numero} - {cliente.Cidade} ({cliente.TipoEndereco})");

                    // Verifica se o objeto atual é uma Pessoa Física usando "is"
                    if (cliente is PessoaFisica pf)
                    {
                        sw.WriteLine($"Tipo: Pessoa Física");
                        sw.WriteLine($"CPF: {pf.CPF}");
                        sw.WriteLine($"Data de Nascimento: {pf.DataNascimento:dd/MM/yyyy}");
                    }
                    // Verifica se é uma Pessoa Jurídica
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
