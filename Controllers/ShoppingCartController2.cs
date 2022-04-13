// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using AppEcommerce.Interfaces;
// using AppEcommerce.Models;
// using AppEcommerce.ViewModels;
// using System.Text.Encodings.Web;
// using System.Threading.Tasks;
// using AppEcommerce.Data;
// using System.Linq;

// namespace AppEcommerce.Controllers
// {
//     /*O controlador do carrinho de compras tem três objetivos principais: 
//      * adicionar itens a um carrinho, remover itens do carrinho e exibir itens no carrinho. 
//      * Ele fará uso das três classes que acabamos de criar: ShoppingCartViewModel, 
//      * ShoppingCartRemoveViewModel e ShoppingCart.
//      */
//     public class ShoppingCartController : Controller
//     {
//         private Contexto _contexto;
//         private IShoppingCart _shoppingCart;
//         public ShoppingCartController(Contexto contexto, IShoppingCart shoppingCart)
//         {
//             _contexto = contexto;
//             _shoppingCart = shoppingCart;
//         }

//         //GET shoppingCart
//         public ActionResult Index()
//         {
//             ViewData["Categorias"] = _contexto.Categorias.ToList();
//             _shoppingCart = _shoppingCart.GetCart(this.HttpContext);

//             var viewModel = new ShoppingCartViewModel
//             {
//                 CartItems = _shoppingCart.GetCartItems(),
//                 CartTotal = _shoppingCart.GetTotal()
//             };

//             return View(viewModel);
//         }

//         public async Task<IActionResult> AddToCart(int id)
//         {
//             ViewData["Categorias"] = _contexto.Categorias.ToList();

//             var addedAlbum = _contexto.Produtos.Find(id);

//             _shoppingCart = _shoppingCart.GetCart(this.HttpContext);

//             _shoppingCart.AddToCart(addedAlbum);

//             return RedirectToAction(nameof(Index));
//         }

//         public ActionResult Cart(int id)
//         {
//             ViewData["Categorias"] = _contexto.Categorias.ToList();
//             // Retrieve the album from the database
//             var addedProduto = _contexto.Produtos
//                 .Single(p => p.Id == id);

//             // Add it to the shopping cart
//             var cart = _shoppingCart.GetCart(this.HttpContext);

//             cart.AddToCart(addedProduto);

//             // Go back to the main store page for more shopping
//             return RedirectToAction("Index");
//         }


//         // AJAX: /ShoppingCart/RemoveFromCart/5
//         [HttpPost]
//         public ActionResult RemoveFromCart(int id)
//         {
//             ViewData["Categorias"] = _contexto.Categorias.ToList();
//             // Remove the item from the cart
//             var cart = _shoppingCart.GetCart(this.HttpContext);

//             // Get the name of the album to display confirmation
//             string ProdutoName = _contexto.Tab_Cart
//                 .Single(item => item.RecordId == id).Produto.Nome;

//             // Remove from cart
//             int itemCount = cart.RemoveFromCart(id);

//             // Display the confirmation message
//             var results = new ShoppingCartRemoveViewModel
//             {
//                 Message = ProdutoName + "Foi removido do seu carrinho de compras!",
//                 CartTotal = cart.GetTotal(),
//                 CartCount = cart.GetCount(),
//                 ItemCount = itemCount,
//                 DeleteId = id
//             };
//             return Json(results);
//         }

//         // GET: /ShoppingCart/CartSummary
//         public ActionResult CartSummary()
//         {
//             ViewData["Categorias"] = _contexto.Categorias.ToList();
//             var cart = _shoppingCart.GetCart(this.HttpContext);

//             ViewData["CartCount"] = cart.GetCount();
//             return PartialView("CartSummary");
//         }

//         public int GetCount()
//         {
//             _shoppingCart = _shoppingCart.GetCart(this.HttpContext);
//             return _shoppingCart.GetCount();
//         }

//         //AJAX: /ShoppingCart/RemoveFromCart/5

//         /*Um conceito novo que o ASP.NET MVC 6 traz é o View Components, cuja ideia principal é ser algo parecido com uma partial view,
//          * porém com muito mais recursos como testabilidade, isolamento de conceitos.
//          * Basicamente é possível fazer uma comparação como um mini controller, que é responsável pela renderização de um bloco só da pagina.
//          * Exemplos de uso: dados do usuário, menus customizados, informações de últimos produtos, promoções, algo que possua uma lógica
//          * e implementação um pouco mais complexa que uma Partial View.
//          */
//     }
// }
