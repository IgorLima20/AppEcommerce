using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppEcommerce.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AppEcommerce.Models
{
    public class ShoppingCart
    {   
        private readonly Contexto _contexto;

        private ShoppingCart(Contexto contexto)
        {
            _contexto = contexto;
        } 

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider services)
        {

            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<Contexto>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Produto produto, int amount)
        {
            var shoppingCartItem = 
                _contexto.ShoppingCartItems.SingleOrDefault(
                    s => s.Produto.Id == produto.Id && s.ShoppingCartId == ShoppingCartId);
            
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Produto = produto,
                    Amount = 1
                };
                _contexto.ShoppingCartItems.Add(shoppingCartItem);
            }  
            else
            {
                shoppingCartItem.Amount++;
            }   
            _contexto.SaveChanges();
        }

        public int RemoveFromCart(Produto produto)
        {
            var shoppingCartItem =
                    _contexto.ShoppingCartItems.SingleOrDefault(
                        s => s.Produto.Id == produto.Id && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _contexto.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }   
            _contexto.SaveChanges();

            return localAmount;         
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                    (ShoppingCartItems =
                        _contexto.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                            .Include(s => s.Produto).ToList());
        }

        public void ClearCart()
        {
            var cartItems = _contexto
                .ShoppingCartItems.Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _contexto.ShoppingCartItems.RemoveRange(cartItems);
            _contexto.SaveChanges();    
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _contexto.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Produto.Valor * c.Amount).Sum();
            return total;
        }
    }
}