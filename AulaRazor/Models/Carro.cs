using System.ComponentModel.DataAnnotations;

namespace AulaRazor.Models
{
    public class Carro
    {
        public string? Modelo { get; set; }

        public string? Fabricante { get; set; }

        public int Ano { get; set; }

        //Altera o texto do label
        [Display(Name = "Automático")]
        public bool Automatico { get; set; }
        public decimal Valor { get; set; }

        public Combustivel Combustivel { get; set; }
    }

    public enum Combustivel
    {
        Etanol, Gasolina, Flex, Eletrico
    }
}
