using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppEcommerce.Models
{
    [Table("ItemPedido")]
    public class ItemPedido
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid IdPedido { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid IdProduto { get; set; }

        [Required]
        public int Quantidade { get; set; }

        public double ValorUnitario { get; set; }

        [ForeignKey("IdPedido")]
        public Pedido Pedido { get; set; }

        [ForeignKey("IdProduto")]
        public Produto Produto { get; set; }

        [NotMapped]
        public double ValorItem { get => this.Quantidade * this.
            ValorUnitario;}
    }
}