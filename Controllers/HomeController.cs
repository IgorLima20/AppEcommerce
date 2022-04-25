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

        public IActionResult Filtro(Guid Id, int? pagina)
        {
            var pageSize = 9;
            int pageNumber = pagina ?? 1;

            ViewData["ShoppingCartId"] = _contexto.ShoppingCartItems;
            ViewData["Categorias"] = _contexto.Categorias.ToList();
            var filtro = _contexto.Produtos.Where(c => c.IdCategoria == Id).Include(i => i.Categoria).ToPagedList(pageNumber, pageSize);
            return View(filtro);
        }

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
