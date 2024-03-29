﻿using AppEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppEcommerce.ViewModels
{
    // usado para exibir informações quando o produto for removido do carrinho.
    public class ShoppingCartRemoveViewModel
    {
        public string Message { get; set; }
        public decimal CartTotal { get; set; }
        public int CartCount { get; set; }
        public int ItemCount { get; set; }
        public int DeleteId { get; set; } 
        public int ListaProd { get; set; }
    }
}
