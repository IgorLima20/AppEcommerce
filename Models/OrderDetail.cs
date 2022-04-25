using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEcommerce.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProdutoId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Order Order { get; set; }
    }
}