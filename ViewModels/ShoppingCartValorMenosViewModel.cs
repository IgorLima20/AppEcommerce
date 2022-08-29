using AppEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppEcommerce.ViewModels
{
    // usado para exibir informações quando diminuir a quantidade do produto no carrinho.
    public class ShoppingCartValorMenosViewModel
    {
        public decimal CartTotal { get; set; }
        public string Mensagem { get; set; }
        public decimal CartCount { get; set; }
        public int ItemCount { get; set; }
        public int DeleteId { get; set; } 
    }
}
