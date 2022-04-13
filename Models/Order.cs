// using System;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;
// using System.Linq;
// using System.Threading.Tasks;

// namespace AppEcommerce.Models
// {
//     public class Order
//     {
//         [Key]
//         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//         public int OrderId { get; set; }
        
//         public string Country { get; set; }

//         public string? IdCliente { get; set; }

//         [ForeignKey("IdCliente")]
//         public Cliente? Cliente { get; set; }

//         public Guid? IdEndereco { get; set; }

//         [ForeignKey("IdEndereco")]
//         public Endereco? EnderecoEntrega { get; set; }

//         [Column(TypeName = "decimal(18,2)")]
//         public decimal Total { get; set; }
//         public DateTime OrderDate { get; set; }
//         public List<OrderDetail> OrderDetails { get; set; }
//     }
// }
