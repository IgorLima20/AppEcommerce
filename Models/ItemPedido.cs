using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppEcommerce.Models
{
    public class ItemPedido
    {   
        [Key, Column(Order = 1)]
        public Guid IdPedido { get; set; }

        [ForeignKey("IdPedido")]
        public Pedido Pedido { get; set; }

        [Key, Column(Order = 2)]
        public Guid IdProduto { get; set; }

        [ForeignKey("IdProduto")]
        public Produto Produto { get; set; }

        [Required]
        public int Quantidade { get; set; }

        public double ValorUnitario { get; set; }

        [NotMapped]
        public double ValorItem { get => this.Quantidade * this.ValorUnitario;}
    }
}