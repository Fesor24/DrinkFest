using DrinkFest.ViewModel;
using DrinkFest.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using DrinkFest.Models;

namespace DrinkFest.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;

        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;

        }
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Drinks> drinks;

            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                drinks = _drinkRepository.Drinks.OrderBy(n => n.DrinkId);
                currentCategory = "All Drinks";
            }
            else
            {
                if(string.Equals("Alcoholic", _category, StringComparison.OrdinalIgnoreCase))
                {
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryId.Equals(50));
                }
                else
                {
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryId.Equals(51));

                }

                currentCategory = _category;
            }

            var drinkListViewModel = new DrinkListViewModel
            {
                Drink = drinks,
                CurrentCategory = currentCategory
            };

            return View(drinkListViewModel);
        }
    }
}
