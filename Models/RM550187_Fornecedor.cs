using System.ComponentModel.DataAnnotations;

namespace ProvaEFCore.App.Models
{
    public class RM550187_Fornecedor
    {
        [Key]
        public int idFornecedor { get; set; }

        [Required, MaxLength(9)]
        public string nrCEP { get; set; } = string.Empty;

        [Required, MaxLength(200)]
        public string dsEndereco { get; set; } = string.Empty;

        [Required, MaxLength(2)]
        public string Estado { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Cidade { get; set; } = string.Empty;
    }
}
