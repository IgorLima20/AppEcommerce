// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;

// namespace AppEcommerce.Models
// {
//     public class OrderDetail
//     {
//         [Key]
//         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//         public int OrderDetailId { get; set; }
//         public int OrderId { get; set; }
//         public int ProdutoId { get; set; }
//         public int Quantity { get; set; }
//         [Column(TypeName = "decimal(18,2)")]
//         public decimal UnitPrice { get; set; }
//         public virtual Produto Produto { get; set; }
//         public virtual Order Order { get; set; }
//     }
// }