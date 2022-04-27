using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AppEcommerce.Data;
using AppEcommerce.Interfaces;
using AppEcommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppEcommerce.Controllers
{
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private Contexto _contexto;
        private ShoppingCart _shoppingCart;

        private readonly IOrderRepository _orderRepository;
        public OrderController(Contexto contexto, ShoppingCart shoppingCart, IOrderRepository orderRepository)
        {
            _contexto = contexto;
            _shoppingCart = shoppingCart;
            _orderRepository = orderRepository;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        // [HttpPost]
        // [Authorize]
        // public IActionResult Checkout(Order order)
        // {
        //     var items = _shoppingCart.GetShoppingCartItems();
        //     _shoppingCart.ShoppingCartItems = items;
        //     if (_shoppingCart.ShoppingCartItems.Count == 0)
        //     {
        //         ModelState.AddModelError("", "Your card is empty, add some drinks first");
        //     }

        //     if (ModelState.IsValid)
        //     {
        //         _orderRepository.CreateOrder(order);
        //         _shoppingCart.ClearCart();
        //         return RedirectToAction("CheckoutComplete");
        //     }

        //     return View(order);
        // }

        // public IActionResult CheckoutComplete()
        // {
        //     ViewBag.CheckoutCompleteMessage = "Thanks for your order! :) ";
        //     return View();
        // }
    }
}