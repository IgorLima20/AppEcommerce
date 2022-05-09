using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppEcommerce.Models;
using AppEcommerce.Data;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace AppEcommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly Contexto _contexto;

        // private ShoppingCart _shoppingCart;

        public HomeController(ILogger<HomeController> logger, Contexto contexto)
        {
            _logger = logger;
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            ViewData["ShoppingCartId"] = _contexto.ShoppingCartItems;
            ViewData["Categorias"] = _contexto.Categorias.Take(6);
            var produtos = _contexto.Produtos.OrderBy(p => p.Id).Include(c => c.Categoria).Take(8);
            return View(produtos);
        }

        public IActionResult Show(int Id, Guid IdCategoria)
        {
            ViewData["ShoppingCartId"] = _contexto.ShoppingCartItems;
            ViewData["Categorias"] = _contexto.Categorias.ToList();
            ViewData["Marca"] = _contexto.Marcas.ToList();
            ViewData["Produtos"] = _contexto.Produtos.Where(c => c.IdCategoria == IdCategoria).Where(s => s.Id != Id).Include(i => i.Categoria).Take(4).ToList();
            var produto = _contexto.Produtos.Where(v => v.Id == Id).Include(m => m.Categoria).SingleOrDefault();
            return View(produto);
        }

        public async Task<IActionResult> Filtro(Guid Id, int? pagina, string sortOrder, string currentFilter, string searchString, int? pageNumber, Guid? Idmarca, Guid marca)
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
                    Idmarca = marca;
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
                                prod = prod.Where(s => s.Nome.Contains(searchString)).Where(m => m.IdMarca == Idmarca).OrderByDescending(m => m.Valor);
                                break;
                            case "menor":
                                prod = prod.Where(s => s.Nome.Contains(searchString)).Where(m => m.IdMarca == Idmarca).OrderBy(m => m.Valor);
                                break;
                            case "todos":
                                prod = prod.Where(s => s.Nome.Contains(searchString)).Where(m => m.IdMarca == Idmarca);
                                break;
                            default:
                                prod = prod.Where(s => s.Nome.Contains(searchString)).Where(m => m.IdMarca == Idmarca);
                                break;
                        }
                    }
                    else
                    {
                        switch (sortOrder)
                        {
                            case "maior":
                                prod = prod.Where(s => s.Nome.Contains(searchString)).OrderByDescending(m => m.Valor);
                                break;
                            case "menor":
                                prod = prod.Where(s => s.Nome.Contains(searchString)).OrderBy(m => m.Valor);
                                break;
                            case "todos":
                                prod = prod.Where(s => s.Nome.Contains(searchString));
                                break;
                            default:
                                prod = prod.Where(s => s.Nome.Contains(searchString));
                                break;
                        }
                    }

                    ViewData["Marcas"] = prod.Where(s => s.Nome.Contains(searchString)).Include(m => m.Marca).Select(i => i.Marca).Distinct();
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

                ViewData["Marcas"] = prod.Where(c => c.IdCategoria == Id).Include(m => m.Marca).Select(i => i.Marca).Distinct();
            }
            int pageSize = 9;
            return View(await PaginatedList<Produto>.CreateAsync(prod.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // public IActionResult Filtro(Guid Id, int? pagina)
        // {
        //     var pageSize = 9;
        //     int pageNumber = pagina ?? 1;

        //     ViewData["ShoppingCartId"] = _contexto.ShoppingCartItems;
        //     ViewData["Categorias"] = _contexto.Categorias.ToList();
        //     var filtro = _contexto.Produtos.Where(c => c.IdCategoria == Id).Include(i => i.Categoria).ToPagedList(pageNumber, pageSize);
        //     return View(filtro);
        // }

        public IActionResult Categoria(Guid id, int? pagina)
        {
            var pageSize = 9;
            int pageNumber = pagina ?? 1;

            var categoria = _contexto.Categorias.Where(c => c.Id == id).ToPagedList(pageNumber, pageSize);
            return View("Filtro", categoria);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
