using System.ComponentModel.DataAnnotations;

namespace ControloDeCompras.Models
{
    public class ShoppingList
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O genero é de preenchimento obrigatório.")]
        public string Genero { get; set; } = null!;


        public string? Nome { get; set; } = null!;


        public string? Variedade { get; set; } = null!;


        [Required(ErrorMessage = "A quantidade é de preenchimento obrigatório.")]
        public int Quantidade { get; set; }


        public double? Preco { get; set; }

    }
}