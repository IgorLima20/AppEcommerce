using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppEcommerce.Data;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using AppEcommerce.Models;
using Microsoft.AspNetCore.Identity;

namespace AppEcommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly Contexto _contexto;

        private readonly UserManager<User> userManager;

        // private ShoppingCart _shoppingCart;

        public HomeController(ILogger<HomeController> logger, Contexto contexto, UserManager<User> user)
        {
            userManager = user;
            _logger = logger;
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            ViewData["ShoppingCartId"] = _contexto.ShoppingCartItems;
            ViewData["Categorias"] = _contexto.Categorias.Include(c => c.Produtos).Take(12);
            ViewData["ImagensCarrosel"] = _contexto.ImagensSite.Where(i => i.Carrosel).OrderBy(p => p.Ordem).ToList();
            ViewData["ImagenSenc"] = _contexto.ImagensSite.Where(i => i.Secundaria).OrderBy(p => p.Ordem).Take(2).ToList();
            ViewData["Marcas"] = _contexto.Marcas.Where(f => f.ExibirHome).ToList();
            var produtos = _contexto.Produtos.Where(e => e.ExibirHome).OrderBy(p => p.Id).Include(c => c.Categoria).Take(8);
            return View(produtos);
        }

        public IActionResult Show(int Id, int IdCategoria)
        {
            ViewData["ShoppingCartId"] = _contexto.ShoppingCartItems;
            ViewData["Categorias"] = _contexto.Categorias.ToList();
            ViewData["Marca"] = _contexto.Marcas.ToList();
            ViewData["Produtos"] = _contexto.Produtos.Where(c => c.IdCategoria == IdCategoria).Where(s => s.Id != Id).Include(i => i.Categoria).Take(4).ToList();
            var produto = _contexto.Produtos.Where(v => v.Id == Id).Include(m => m.Categoria).Include(i => i.Imagem).SingleOrDefault();
            return View(produto);
        }

        public async Task<IActionResult> Filtro(int Id, int? pagina, string sortOrder, string currentFilter, string searchString, int? pageNumber, int? Idmarca, int marca)
        {

            ViewData["CurrentSort"] = sortOrder;
            ViewData["Maior"] = String.IsNullOrEmpty(sortOrder) ? "maior" : "maior";
            ViewData["Menor"] = String.IsNullOrEmpty(sortOrder) ? "menor" : "menor";
            ViewData["Todos"] = String.IsNullOrEmpty(sortOrder) ? "todos" : "todos";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
                if (Idmarca == null)
                {
                    if (marca != 0)
                    {
                        Idmarca = marca;
                    }
                }

            }



            ViewData["CurrentFilter"] = searchString;

            var prod = from p in _contexto.Produtos
                       select p;

            if (searchString != null)
            {
                if (!String.IsNullOrEmpty(searchString))
                {
                    if (Idmarca != null)
                    {
                        ViewData["MarcaId"] = Idmarca;
                        switch (sortOrder)
                        {
                            case "maior":
                                prod = prod.Where(s => s.NomeDescricao.Contains(searchString)).Where(m => m.IdMarca == Idmarca).OrderByDescending(m => m.Valor);
                                break;
                            case "menor":
                                prod = prod.Where(s => s.NomeDescricao.Contains(searchString)).Where(m => m.IdMarca == Idmarca).OrderBy(m => m.Valor);
                                break;
                            case "todos":
                                prod = prod.Where(s => s.NomeDescricao.Contains(searchString)).Where(m => m.IdMarca == Idmarca);
                                break;
                            default:
                                prod = prod.Where(s => s.NomeDescricao.Contains(searchString)).Where(m => m.IdMarca == Idmarca);
                                break;
                        }
                    }
                    else
                    {
                        switch (sortOrder)
                        {
                            case "maior":
                                prod = prod.Where(s => s.NomeDescricao.Contains(searchString)).OrderByDescending(m => m.Valor);
                                break;
                            case "menor":
                                prod = prod.Where(s => s.NomeDescricao.Contains(searchString)).OrderBy(m => m.Valor);
                                break;
                            case "todos":
                                prod = prod.Where(s => s.NomeDescricao.Contains(searchString));
                                break;
                            default:
                                prod = prod.Where(s => s.NomeDescricao.Contains(searchString));
                                break;
                        }
                    }

                    ViewData["Marcas"] = prod.Where(s => s.NomeDescricao.Contains(searchString)).Include(m => m.Marca).Select(i => i.Marca).Distinct();
                }
            }
            else
            {
                if (Idmarca != null)
                {
                    switch (sortOrder)
                    {
                        case "maior":
                            prod = prod.Where(c => c.IdCategoria == Id).Include(i => i.Categoria).OrderByDescending(m => m.Valor);
                            break;
                        case "menor":
                            prod = prod.Where(c => c.IdCategoria == Id).Include(i => i.Categoria).OrderBy(m => m.Valor);
                            break;
                        case "todos":
                            prod = prod.Where(c => c.IdCategoria == Id).Include(i => i.Categoria);
                            break;
                        default:
                            prod = prod.Where(c => c.IdCategoria == Id).Include(i => i.Categoria);
                            break;
                    }
                }
                else
                {
                    if (Id > 0 )
                    {
                        switch (sortOrder)
                        {
                            case "maior":
                                prod = prod.Where(c => c.IdCategoria == Id).Include(i => i.Categoria).OrderByDescending(m => m.Valor);
                                break;
                            case "menor":
                                prod = prod.Where(c => c.IdCategoria == Id).Include(i => i.Categoria).OrderBy(m => m.Valor);
                                break;
                            case "todos":
                                prod = prod.Where(c => c.IdCategoria == Id).Include(i => i.Categoria);
                                break;
                            default:
                                prod = prod.Where(c => c.IdCategoria == Id).Include(i => i.Categoria);
                                break;
                        }
                    }
                    else
                    {
                         switch (sortOrder)
                        {
                            case "maior":
                                prod = prod.Include(i => i.Categoria).OrderByDescending(m => m.Valor);
                                break;
                            case "menor":
                                prod = prod.Include(i => i.Categoria).OrderBy(m => m.Valor);
                                break;
                            case "todos":
                                prod = prod.Include(i => i.Categoria);
                                break;
                            default:
                                prod = prod.Include(i => i.Categoria);
                                break;
                        }
                    }
                   
                }

                ViewData["Marcas"] = prod.Where(c => c.IdCategoria == Id).Include(m => m.Marca).Select(i => i.Marca).Distinct();
            }
            int pageSize = 8;
            return View(await PaginatedList<Produto>.CreateAsync(prod.AsNoTracking(), pageNumber ?? 1, pageSize));
        }


        public IActionResult Categoria(int id, int? pagina)
        {
            var pageSize = 9;
            int pageNumber = pagina ?? 1;

            var categoria = _contexto.Categorias.Where(c => c.Id == id).ToPagedList(pageNumber, pageSize);
            return View("Filtro", categoria);
        }


        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contato(Contato contato)
        {
           if (ModelState.IsValid)
            {
                _contexto.Add(contato);
                if (await _contexto.SaveChangesAsync() > 0)
                {
                    ViewBag.Concluido = "OK";
                    return View(contato);
                }
                else
                {
                    ViewBag.Concluido = "ERRO";
                    return View(contato);
                }
            }
            else
            {
                return View(contato);
            }
        }

        public async Task<IActionResult> Category(int? pagina, string searchString, int? pageNumber)
        {
            var categoria = _contexto.Categorias.OrderBy(p => p.Id);
            int pageSize = 9;
            return View(await PaginatedList<Categoria>.CreateAsync(categoria.AsNoTracking(), pageNumber ?? 1, pageSize));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
