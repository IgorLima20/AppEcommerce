using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AppEcommerce.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AppEcommerce.Controllers
{
    [Authorize(Roles = "Administrador, Moderador")]
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        private readonly Contexto _contexto;

        public AdminController(ILogger<AdminController> logger, Contexto contexto)
        {
            _logger = logger;
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            ViewData["Categorias"] = _contexto.Categorias.Take(6);
            var produtos = _contexto.Produtos.OrderBy(p => p.Id).Include(c => c.Categoria).Take(8);
            return View(produtos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}