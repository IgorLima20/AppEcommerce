using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AppEcommerce.Data;
using AppEcommerce.Models;
using AppEcommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppEcommerce.Controllers
{
    public class ShoppingCartController : Controller
    {

        private Contexto _contexto;
        private ShoppingCart _shoppingCart;
        public ShoppingCartController(Contexto contexto, ShoppingCart shoppingCart)
        {
            _contexto = contexto;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            ViewData["ShoppingCartId"] = _contexto.ShoppingCartItems;
            ViewData["Categorias"] = _contexto.Categorias.ToList();
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var sCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(sCVM);
        }

        public RedirectToActionResult AddToShoppingCart(int Id)
        {
            ViewData["ShoppingCartId"] = _contexto.ShoppingCartItems;
            ViewData["Categorias"] = _contexto.Categorias.ToList();
            var selectedProduto = _contexto.Produtos.FirstOrDefault(p => p.Id == Id);
            if (selectedProduto != null)
            {
                _shoppingCart.AddToCart(selectedProduto, 1);
            } 
            return RedirectToAction("Index"); 
        }

        public RedirectToActionResult RemoveFromShoppingCart(int Id)
        {
            ViewData["Categorias"] = _contexto.Categorias.ToList();
            var selectedProduto = _contexto.Produtos.FirstOrDefault(p => p.Id == Id);
            if (selectedProduto != null)
            {
                _shoppingCart.RemoveFromCart(selectedProduto);
            }
            return RedirectToAction("Index");
        }

    }
}