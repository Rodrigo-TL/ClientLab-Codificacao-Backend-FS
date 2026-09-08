# ClientLab - Sistema de Cadastro de Clientes

Este é um sistema de console desenvolvido em C# (.NET) para a empresa ClientLab. O objetivo da aplicação é gerenciar e estruturar o cadastro de clientes corporativos (Pessoas Jurídicas) e individuais (Pessoas Físicas), aplicando conceitos fundamentais de Programação Orientada a Objetos (POO), validações de segurança e persistência de dados em arquivos locais.

---

## 🚀 Features (Funcionalidades)

- **Cadastro de Pessoa Física (PF):**
  - Armazenamento de Nome, CPF e Data de Nascimento.
  - Validação impeditiva de idade: impede o cadastro de menores de 18 anos.
  - Cálculo automatizado de imposto com alíquota de 3% sobre os rendimentos.
- **Cadastro de Pessoa Jurídica (PJ):**
  - Armazenamento de Nome Fantasia, Razão Social e CNPJ.
  - Validação rigorosa do CNPJ: exige 14 dígitos numéricos e a presença obrigatória do sufixo `0001`.
  - Cálculo automatizado de imposto com alíquota de 5% sobre os rendimentos.
- **Gerenciamento de Endereços:**
  - Vinculação de logradouro, número, cidade e classificação do tipo de endereço (Residencial ou Comercial) para ambos os tipos de perfis.
- **Persistência de Dados:**
  - Exportação automática das informações coletadas para arquivos de texto individuais no formato `.txt`, nomeados dinamicamente com o nome de cada cliente registrado.

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Função no Projeto |
| :--- | :--- |
| **C# (.NET 8.0 / 10.0)** | Linguagem de programação principal do Server-side. |
| **System.IO** | Biblioteca nativa utilizada para a criação e manipulação dos arquivos `.txt`. |
| **System.Text.RegularExpressions** | Biblioteca utilizada para a validação de formato e limpeza de strings de CNPJ. |
| **Git & GitHub** | Ferramentas para controle de versão e rastreabilidade do código fonte. |

---

## 📁 Organização do Projeto

A estrutura de arquivos do repositório está organizada de forma modular e coesa:

* `Pessoa.cs`: Classe base abstrata contendo as propriedades comuns de identificação e endereço, além do contrato para o método de imposto.
* `PessoaFisica.cs`: Classe derivada que estende os atributos individuais e implementa a validação de idade e a alíquota de 3%.
* `PessoaJuridica.cs`: Classe derivada que estende as propriedades empresariais e implementa a validação de CNPJ e a alíquota de 5%.
* `GerenciadorArquivo.cs`: Classe estática responsável pelo fluxo de saída, formatação e gravação dos dados no disco.
* `Program.cs`: Ponto de entrada da aplicação contendo os cenários de testes automatizados e depuração do sistema.

---

## 📌 Pré-requisitos de Instalação

Para baixar, compilar e executar este projeto localmente em sua máquina, você precisará de:

1. **SDK do .NET:** Versão 8.0 ou superior instalada.
2. **Ambiente de Desenvolvimento:** Visual Studio Code ou Visual Studio instalado.
3. **Extensão C#:** Extensão oficial da Microsoft instalada no VS Code para suporte ao código.

---

## 💻 Execução da Aplicação

Siga as instruções abaixo no terminal de sua máquina para clonar e rodar o projeto:

1. Abra o terminal e mude para o diretório onde deseja clonar o projeto:
   ```bash
   cd "caminho-da-sua-pasta"
   ```
2. Execute o comando de compilação e inicialização do console:
   ```bash
   dotnet run
   ```

---

## ⚠️ Erros Comuns

* **Erro de Comando não Encontrado (`dotnet: command not found`):**
  * *Causa:* O SDK do .NET não está instalado ou o terminal foi aberto antes da instalação finalizar.
  * *Solução:* Certifique-se de concluir a instalação do SDK e reinicie completamente o VS Code.
* **Exceção de Validação de Idade (`ArgumentException: Erro: Apenas pessoas com idade igual ou superior...`):**
  * *Causa:* Tentativa de instanciar uma data de nascimento que resulte em menos de 18 anos em relação à data atual.
  * *Solução:* Forneça uma data válida correspondente a um maior de idade nos parâmetros de teste.
* **Exceção de CNPJ Inválido (`ArgumentException: Erro: CNPJ inválido...`):**
  * *Causa:* O CNPJ informado não possui exatamente 14 dígitos numéricos ou não contém o miolo `0001`.
  * *Solução:* Verifique os caracteres e insira um CNPJ que cumpra o padrão exigido pelas regras de negócio.

---

## 👥 Contribuidor

* **Rodrigo** - Estudante de Desenvolvimento Back-End.
