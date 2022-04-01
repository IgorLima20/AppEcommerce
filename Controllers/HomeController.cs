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

namespace AppEcommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly Contexto _contexto;

        public HomeController(ILogger<HomeController> logger,  Contexto contexto)
        {
            _logger = logger;
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            ViewData["Categorias"] = _contexto.Categorias.ToList();
            var produtos = _contexto.Produtos.Include(c => c.Categoria ).ToList();
            return View(produtos);
        }

        public IActionResult Show(Guid Id)
        {
            ViewData["Categorias"] = _contexto.Categorias.ToList();
            ViewData["Marca"] = _contexto.Marcas.ToList();
            var produto = _contexto.Produtos.Where(v => v.Id == Id).Include(m => m.Categoria).SingleOrDefault();
            return View(produto);
           
        }

        public IActionResult Filtro(Guid Id)
        {   
            ViewData["Categorias"] = _contexto.Categorias.ToList();
            var filtro = _contexto.Produtos.Where(c => c.IdCategoria == Id).Include(i => i.Categoria).ToList();
            return View(filtro);
        }

        public IActionResult Partes()
        {
            ViewData["Categorias"] = _contexto.Categorias.ToList();
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
