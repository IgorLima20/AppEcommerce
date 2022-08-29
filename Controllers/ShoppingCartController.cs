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
            ViewData["ShoppingCartItems"] = _contexto.ShoppingCartItems;
            ViewData["Categorias"] = _contexto.Categorias.ToList();
            var selectedProduto = _contexto.Produtos.FirstOrDefault(p => p.Id == Id);
            if (selectedProduto != null)
            {
                _shoppingCart.AddToCart(selectedProduto);
            } 
            return RedirectToAction("Index"); 
        }

        [HttpPost]
        public JsonResult AddToShopping(int Id)
        {
            ViewData["ShoppingCartItems"] = _contexto.ShoppingCartItems;
            ViewData["Categorias"] = _contexto.Categorias.ToList();
            var selectedProduto = _contexto.Produtos.FirstOrDefault(p => p.Id == Id);
           
            
            int Amount = _shoppingCart.AddToCart(selectedProduto);

            var results = new ShoppingCartValorViewModel
            {
                CartTotal = _shoppingCart.GetShoppingCartTotal(),
                ItemCount = Amount,
                CartCount = selectedProduto.Valor,
                Mensagem = _shoppingCart.Mensagem,
                DeleteId = Id
            };
            
            return Json(results);
        }

        [HttpPost]
        public JsonResult RemoveFromShoppingCart(int Id)
        {
            ViewData["Categorias"] = _contexto.Categorias.ToList();
            var selectedProduto = _contexto.Produtos.FirstOrDefault(p => p.Id == Id);
            
             int Amount = _shoppingCart.RemoveFromCart(selectedProduto);
            
            var results = new ShoppingCartValorMenosViewModel
            {
                CartTotal = _shoppingCart.GetShoppingCartTotal(),
                ItemCount = Amount,
                CartCount = selectedProduto.Valor,
                Mensagem = _shoppingCart.Mensagem,
                DeleteId = Id
            };
            return Json(results);
           
        }

        [HttpPost]
        public JsonResult RemoveProdShoppingCart(int Id)
        {
            ViewData["Categorias"] = _contexto.Categorias.ToList();
            var selectedProduto = _contexto.Produtos.FirstOrDefault(p => p.Id == Id);

            int localAmount = _shoppingCart.RemoveProd(selectedProduto);
            var items = _shoppingCart.GetShoppingCartItems().Count();

            var results = new ShoppingCartRemoveViewModel
            {
                CartTotal = _shoppingCart.GetShoppingCartTotal(),
                ItemCount = localAmount,
                DeleteId = Id,
                ListaProd = items
            };
            return Json(results);
        }

    }
}