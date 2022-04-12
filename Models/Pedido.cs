using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEcommerce.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdPedido { get; set; }

        [Required]
        public DateTime DataPedido { get; set; }
        
        [Required]
        public DateTime DataEntrega { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public double ValorTotal { get; set; }

        public string? IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente? Cliente { get; set; }

        public string IdCarrinho { get; set; }
        
        public Guid? IdEndereco { get; set; }

        [ForeignKey("IdEndereco")]
        public Endereco? EnderecoEntrega { get; set; }

        public  ICollection<ItemPedido> ItensPedido { get; set; }
    }
}