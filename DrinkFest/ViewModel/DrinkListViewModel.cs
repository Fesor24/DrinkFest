using DrinkFest.Models;

namespace DrinkFest.ViewModel
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drinks> Drink { get; set; }
        public string CurrentCategory { get; set; }
    }
}
