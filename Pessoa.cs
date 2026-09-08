using System;

namespace ClientLab
{
    public abstract class Pessoa
    {
        // Propriedades básicas
        public string Nome { get; set; } = string.Empty;
        
        // Propriedades de Endereço (Etapas 3 e 4)
        public string Logradouro { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string TipoEndereco { get; set; } = string.Empty; // "Residencial" ou "Comercial"

        // Método abstrato para cálculo de imposto (Polimorfismo)
        public abstract double PagarImposto(double rendimento);
    }
}
