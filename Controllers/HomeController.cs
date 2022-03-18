using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppEcommerce.Models;

namespace AppEcommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Marca marca1 = new Marca() {
                Id = new Guid(),
                Nome = "Lenovo"
            };
            Categoria categoria1 = new Categoria() {
                Id = new Guid(),
                Nome = "Notebooks",
                Imagem = "~/img/produtos/01.jpg"
            };
            Produto produto1 = new Produto() {
                Id = new Guid(),
                Nome = "Notebook Lenovo Ultrafino Ideapad Ryzen 5-5500U, 8GB, 256GB SSD, 15.6 Full HD, Linux, Cinza - 82MFS00100",
                Valor = 4940.88,
                Estoque = 20,
                Marca = marca1,
                Descricao = "Notebook Lenovo Ultrafino Ideapad Ryzen 5-5500U, 8GB, 256GB SSD, 15.6 Full HD, Linux, Cinza - 82MFS00100",
                Imagem = "~/img/produtos/01.jpg",
                Categoria = categoria1
            };
            return View(produto1);
        }

        public IActionResult Login()
        {
            return View();
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
