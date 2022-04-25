using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppEcommerce.Data;
using AppEcommerce.Interfaces;
using AppEcommerce.Models;

namespace AppEcommerce.Repository
{
    public class OrderRepository : IOrderRepository
    {

        private readonly Contexto _contexto;

        private ShoppingCart _shoppingCart;

        public OrderRepository(Contexto contexto, ShoppingCart shoppingCart)
        {
            _contexto = contexto;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderDate = DateTime.Now;
            _contexto.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = item.Amount,
                    ProdutoId = item.Produto.Id,
                    OrderId = order.OrderId,
                    Price = item.Produto.Valor
                };
                _contexto.OrderDetails.Add(orderDetail);
            }
            _contexto.SaveChanges();
        }
    }
}