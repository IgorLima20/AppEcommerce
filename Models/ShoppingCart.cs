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

        public string Mensagem { get; set; }

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
                if (produto.Estoque > shoppingCartItem.Amount )
                {
                    shoppingCartItem.Amount++;
                }
                else
                {
                    Mensagem = "O limite máximo de quantidade para esse produto é " + shoppingCartItem.Produto.Estoque;
                }
                
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

        public int RemoveProd(Produto produto)
        {
            var shoppingCartItem =
                    _contexto.ShoppingCartItems.SingleOrDefault(
                        s => s.Produto.Id == produto.Id && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount >= 1)
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

        public void EmptyCart()
        {
            var cartItems = _contexto.ShoppingCartItems.Where(p => p.ShoppingCartId == ShoppingCartId);

            foreach (var cartItem in cartItems)
            {
                _contexto.ShoppingCartItems.Remove(cartItem);
            }

            // Save changes
            _contexto.SaveChanges();
        }

        // public int CreateOrder(Pedido pedido)
        // {
        //     decimal orderTotal = 0;

        //     var cartItems = GetShoppingCartItems();

        //     // Iterate over the items in the cart, adding the order details for each
        //     foreach (var item in cartItems)
        //     {
        //         var pedidoDetalhe = new PedidoDetalhe
        //         {
        //             ProdutoId = item.Produto.Id,
        //             PedidoId = pedido.IdPedido,
        //             UnitPrice = item.Produto.Valor,
        //             Quantity = item.Amount
        //         };

        //         // Set the order total of the shopping cart
        //         orderTotal += (item.Amount * item.Produto.Valor);

        //         _contexto.PedidoDetalhes.Add(pedidoDetalhe);

        //     }

        //     // Set the order's total to the orderTotal count
        //     pedido.Total = orderTotal;

        //     // Save the order
        //     _contexto.SaveChanges();

        //     // Empty the shopping cart
        //     EmptyCart();

        //     // Return the OrderId as the confirmation number
        //     return pedido.IdPedido;
        // }
    }
}