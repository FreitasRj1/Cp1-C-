using System.ComponentModel.DataAnnotations;

namespace ProvaEFCore.App.Models
{
    public class RM550187_Produto
    {
        [Key]
        public int idProduto { get; set; }

        [Required, MaxLength(150)]
        public string nmProduto { get; set; } = string.Empty;

        public decimal preco { get; set; }
    }
}
