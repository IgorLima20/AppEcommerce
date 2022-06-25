using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AppEcommerce.Data;
using AppEcommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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

        private readonly UserManager<User> userManager;

        public AdminController(ILogger<AdminController> logger, Contexto contexto, UserManager<User> user)
        {
            userManager = user;
            _logger = logger;
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            ViewData["Categorias"] = _contexto.Categorias.ToList();
            ViewData["Marcas"] = _contexto.Marcas.ToList();
            ViewData["Usuarios"] =  userManager.Users.ToList();
            ViewData["User"] = userManager.GetUserAsync(User).Result.UserName;
            var produtos = _contexto.Produtos.OrderBy(p => p.Id).Include(c => c.Categoria).ToList();
            return View(produtos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}