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
            var produtos = _contexto.Produtos.Include(c => c.Categoria ).ToList();
            return View(produtos);
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Componetentes()
        {
            return View();
        }

        public IActionResult Partes()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
