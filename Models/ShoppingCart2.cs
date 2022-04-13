// using AppEcommerce.Interfaces;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using AppEcommerce.Data;

// namespace AppEcommerce.Models
// {
//     /*O modelo ShoppingCart manipula o acesso a dados para a tabela de carrinhos.
//      * Além disso, ele tratará a lógica de negócios para a adição e remoção de itens do carrinho de compras.
//      *
//      * Como não queremos exigir que os usuários se inscrevam para uma conta apenas para adicionar itens ao carrinho de compras,
//      * atribuíremos aos usuários um identificador exclusivo temporário (usando um GUID ou um identificador global exclusivo)
//      * quando acessarem o carrinho de compras. Armazenaremos essa ID usando a classe de sessão ASP.NET.
//      */

//     public partial class ShoppingCart : IShoppingCart 
//     {
//         private Contexto _contexto;
//         public string ShoppingCartId { get; set; }
//         public const string CartSessionKey = "CartId";

//         public ShoppingCart() { }

//         public ShoppingCart(Contexto contexto)
//         {
//             this._contexto = contexto; 
//         }

//         /// <summary>
//         /// É um método estático que permite que nossos controladores obtenham um objeto de carrinho.
//         /// Ele usa o método Getcarrinhoid para lidar com a leitura de cartid a partir da sessão do usuário.
//         /// O método getcarrinhoid requer o HttpContextBase para que ele possa ler o Carrinhoid do usuário a partir da sessão do usuário.
//         /// </summary>
//         public ShoppingCart GetCart(HttpContext context)
//         {
//             var cart = new ShoppingCart();
//             cart.ShoppingCartId = cart.GetCartId(context);
//             cart._contexto = _contexto;
//             return cart;
//         }

//         //Helper method to simplify shopping cart calls
//         public ShoppingCart GetCart(Controller controller)
//         {
//             return GetCart(controller.HttpContext);
//         }

//         //nos vamos usar o HttpContext para permitir os acessos aos cookies
//         public string GetCartId(HttpContext context)
//         {
//             if (context.Items[CartSessionKey] is null)
//             {
//                 if (!string.IsNullOrEmpty(context.User.Identity.Name))
//                 {
//                     context.Items[CartSessionKey] = context.User.Identity.Name;
//                 }
//                 else
//                 {
//                     // Generate a new random GUID using System.Guid class
//                     Guid tempCartId = Guid.NewGuid();
//                     //Send tempCartId back to client as a cookie
//                     context.Items[CartSessionKey] = tempCartId.ToString();
//                 }
//             }
//             return context.Items[CartSessionKey].ToString();
//         }

//         public void AddToCart(Produto produto)
//         {
//             //get the matching cart and album instances
//             var cartItem = _contexto.Tab_Cart.SingleOrDefault(
//                 c => c.CartId == ShoppingCartId
//                 && c.ProdutoId == produto.Id);

//             if (cartItem is null)
//             {
//                 //create a new cart item if no cart item exist
//                 cartItem = new Cart
//                 {
//                     ProdutoId = produto.Id,
//                     CartId = ShoppingCartId,
//                     Count = 1,
//                     DateCadastro = DateTime.Now
//                 };
//                 _contexto.Add(cartItem);
//             }
//             else
//             {
//                 //If the item does exist in cart ,
//                 //then add one to the quantity
//                 cartItem.Count++;
//             }
//             _contexto.SaveChangesAsync();
//         }

//         /// <summary>
//         ///  Usa uma ID de álbum e a remove do carrinho do usuário. Se o usuário tiver apenas uma cópia do álbum em seu carrinho, a linha será removida.
//         /// </summary>
//         /// <param name="id">Id do album</param>
//         public int RemoveFromCart(int id)
//         {
//             //Get the cart
//             var cartItem = _contexto.Tab_Cart.Single(cart => cart.CartId == ShoppingCartId && cart.RecordId == id);

//             int itemCount = 0;

//             if (cartItem is not null)
//             {
//                 if (cartItem.Count > 1)
//                 {
//                     cartItem.Count--;
//                     itemCount = cartItem.Count;
//                 }
//                 else
//                 {
//                     _contexto.Tab_Cart.Remove(cartItem);
//                 }
//                 //Salvar as mudanças
//                 _contexto.SaveChangesAsync();
//             }
//             return itemCount;
//         }

//         /// <summary>
//         /// Remove todos os itens do carrinho de compras de um usuário.
//         /// </summary>
//         public void EmptyCart()
//         {
//             var cartItems = _contexto.Tab_Cart.Where(cart => cart.CartId == ShoppingCartId);

//             foreach (var cartItem in cartItems)
//             {
//                 _contexto.Tab_Cart.Remove(cartItem);
//             }
//             //Save changes
//             _contexto.SaveChangesAsync();
//         }

//         /// <summary>
//         /// Recupera uma lista de CartItems para exibição ou processamento.
//         /// </summary>
//         public List<Cart> GetCartItems()
//         {
//             return _contexto.Tab_Cart.Include("Produto").Where(cart => cart.CartId == ShoppingCartId).ToList();
//         }

//         /// <summary>
//         /// Recupera um número total de álbuns que um usuário tem em seu carrinho de compras.
//         /// </summary>
//         public int GetCount()
//         {
//             //Pega o itens no carrinho e soma eles
//             int? count = (from cartItems in _contexto.Tab_Cart
//                           where cartItems.CartId == ShoppingCartId
//                           select (int?)cartItems.Count).Sum();
//             //return 0 se count is null
//             return count ?? 0;
//         }

//         /// <summary>
//         /// Calcula o custo total de todos os itens no carrinho.
//         /// </summary>
//         public decimal GetTotal()
//         {

//             // Multiplique o preço do álbum pela contagem desse álbum para obter
//             // o preço atual de cada um desses álbuns no carrinho
//             // some todos os totais de preço do álbum para obter o total do carrinho
//             decimal? total = (from cartItems in _contexto.Tab_Cart
//                               where cartItems.CartId == ShoppingCartId
//                               select (decimal?)cartItems.Count *
//                               cartItems.Produto.Valor).ToList().Sum();

//             return total ?? decimal.Zero;
//         }

//         /// <summary>
//         /// Converte o carrinho de compras em um pedido durante a fase de check-out.
//         /// </summary>
//         /// <returns>retorna o OrderId como numero de confirmacao</returns>
//         public int CreateOrder(Order order)
//         {
//             decimal orderTotal = 0;

//             var cartItems = GetCartItems();

//             foreach (var item in cartItems)
//             {
//                 var orderDetails = new OrderDetail
//                 {
//                     ProdutoId = item.ProdutoId,
//                     OrderId = order.OrderId,
//                     UnitPrice = item.Produto.Valor,
//                     Quantity = item.Count
//                 };
//                 //set the order total of the shopping cart
//                 orderTotal += (item.Count * item.Produto.Valor);
//                 _contexto.Tab_OrderDetail.Add(orderDetails);
//             }
//             order.Total = orderTotal;

//             _contexto.SaveChangesAsync();
//             EmptyCart();

//             //retorna o ORDERID como numero de confirmacao
//             return order.OrderId;
//         }
//     }
// }