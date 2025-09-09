using System.ComponentModel.DataAnnotations;

namespace ProvaEFCore.App.Models
{
    public class RM550187_Pedido
    {
        [Key]
        public int idPedido { get; set; }

        public DateTime dataPedido { get; set; }

        public decimal valorTotal { get; set; }
    }
}
