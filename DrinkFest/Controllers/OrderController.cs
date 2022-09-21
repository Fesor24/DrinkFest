using Microsoft.AspNetCore.Mvc;
using DrinkFest.Data.Interface;
using DrinkFest.Models;
using Microsoft.AspNetCore.Authorization;

namespace DrinkFest.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        [HttpGet]
        [Authorize]
        public IActionResult CheckOut()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult CheckOut(Order model)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if(_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your card is empty, add some drinks first");
            }
            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(model);
                _shoppingCart.ClearCart();

                return RedirectToAction("OrderComplete");
            }

            return View(model);
        }

        public IActionResult OrderComplete()
        {
            ViewBag.CheckoutMessage = "You will be contacted soon.Thank you for your order! :) ";
            return View();
        }
    }
}
