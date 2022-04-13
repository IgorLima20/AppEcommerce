// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using AppEcommerce.Models;
// using Microsoft.AspNetCore.Http;
// using AppEcommerce.Data;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.EntityFrameworkCore;

// namespace AppEcommerce.Controllers
// {
//     public class CarrinhoController : Controller
//     {
//         private readonly ILogger<HomeController> _logger;

//         private readonly Contexto _contexto;

//         public Pedido Pedido { get; set; }

//         public double TotalPedido { get; set; }

//         private readonly UserManager<User> _userManager;
//         private readonly SignInManager<User> _signInManager;

//         public string COOKIE_NAME
//         {
//             get { return ".AspNetCore.CartId"; }
//         }

//         public CarrinhoController(ILogger<HomeController> logger, Contexto contexto, UserManager<User> userManager,
//             SignInManager<User> signInManager)
//         {
//             _logger = logger;
//             _userManager = userManager;
//             _signInManager = signInManager;
//             _contexto = contexto;
//         }

//         public async Task<IActionResult> Index()
//         {
//             if (Request.Cookies.ContainsKey(COOKIE_NAME))
//             {
//                 var cartId = Request.Cookies[COOKIE_NAME];
//                 Pedido = await _contexto.Pedidos.Include("ItensPedido").Include("ItensPedido.Produto").
//                     FirstOrDefaultAsync(p => p.IdCarrinho == cartId);
//                 if (Pedido != null)
//                 {
//                     if (Pedido.Situacao != Pedido.SituacaoPedido.Carrinho)
//                     {
//                         Response.Cookies.Delete(COOKIE_NAME);
//                         return RedirectToPage("/Index");
//                     }
//                     TotalPedido = Pedido.ItensPedido.Sum(x => x.Quantidade * x.ValorUnitario);
//                 }
//                 else
//                 {
//                     TotalPedido = 0;
//                 }
//             }
//             else
//             {
//                 TotalPedido = 0;
//                 SetCartCookie();
//             }

//             return View(Pedido);
//         }

//         public string SetCartCookie()
//         {
//             var cartId = Guid.NewGuid().ToString();

//             var options = new Microsoft.AspNetCore.Http.CookieOptions()
//             {
//                 Path = "/",
//                 Expires = DateTime.UtcNow.AddDays(90),
//                 IsEssential = true,
//                 Secure = false,
//                 SameSite = Microsoft.AspNetCore.Http.SameSiteMode.None,
//                 HttpOnly = false //necess�rio para acessar vai ajax
//             };

//             Response.Cookies.Append(COOKIE_NAME, cartId, options);

//             return cartId;
//         }

//         public async Task<IActionResult> Adicionar(Guid? id, int qtde = 1)
//         {
//             if (id == null) return NotFound();

//             var produto = await _contexto.Produtos.FindAsync(id);

//             if (produto != null)
//             {
//                 string cartId = null;

//                 if (Request.Cookies.ContainsKey(COOKIE_NAME))
//                 {
//                     cartId = Request.Cookies[COOKIE_NAME];
//                     Pedido = await _contexto.Pedidos.Include("ItensPedido").Include("ItensPedido.Produto").FirstOrDefaultAsync(p => p.IdCarrinho == cartId);
//                 }
//                 else
//                 {
//                     cartId = SetCartCookie();
//                 }

//                 if (Pedido == null)
//                 {
//                     Pedido = new Pedido
//                     {
//                         IdCarrinho = cartId,
//                         DataPedido = DateTime.UtcNow,
//                         ItensPedido = new List<ItemPedido>()
//                     };

//                     User appUser = _signInManager.IsSignedIn(User) ?
//                         await _userManager.GetUserAsync(User) : null;

//                     if (appUser != null)
//                     {
//                         Cliente cliente = await _contexto.Clientes.FirstOrDefaultAsync<Cliente>(
//                             c => c.Email.ToLower().Equals(appUser.Email.ToLower()));

//                         if (cliente != null) Pedido.IdCliente = cliente.Id;
//                     }

//                     _contexto.Pedidos.Add(Pedido);
//                 }

//                 var itemPedido = Pedido.ItensPedido.FirstOrDefault(ip => ip.IdProduto == id);
//                 if (itemPedido == null)
//                 {
//                     Pedido.ItensPedido.Add(new ItemPedido
//                     {
//                         IdProduto = id.Value,
//                         Quantidade = qtde,
//                         ValorUnitario = produto.Valor
//                     });
//                 }
//                 else
//                 {
//                     itemPedido.Quantidade += qtde;
//                 }

//                 if (_contexto.SaveChanges() < 0)
//                 {
//                     ModelState.AddModelError("", "Ocorreu um erro ao adicionar o item ao carrinho.");
//                 }
//             }

//             TotalPedido = Pedido.ItensPedido.Sum(x => x.Quantidade * x.ValorUnitario);

//             ViewData["Categorias"] = _contexto.Categorias.ToList();
//             ViewData["TotalPedido"] = TotalPedido;
//             ViewData["Cookie"] = COOKIE_NAME;

//             return View("Index", Pedido);
//         }

//         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//         public IActionResult Error()
//         {
//             return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//         }
//     }
// }
