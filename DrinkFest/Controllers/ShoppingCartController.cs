using Microsoft.AspNetCore.Mvc;
using DrinkFest.Models;
using DrinkFest.Data.Interface;
using DrinkFest.ViewModel;

namespace DrinkFest.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IDrinkRepository _drinkrepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IDrinkRepository drinkRepository, ShoppingCart shoppingCart)
        {
            _drinkrepository = drinkRepository;
            _shoppingCart = shoppingCart;
        }
        
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var scvm = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(scvm);
        }

        public RedirectToActionResult AddToShoppingCart(int drinkId)
        {
            var selectedDrink = _drinkrepository.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);

            if(selectedDrink != null)
            {
                _shoppingCart.AddToCart(selectedDrink, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int drinkId)
        {
            var selectedDrink = _drinkrepository.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);

            if (selectedDrink != null)
            {
                _shoppingCart.RemoveFromCart(selectedDrink);
            }
            return RedirectToAction("Index");
        }
    }
}
