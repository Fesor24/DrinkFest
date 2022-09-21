using DrinkFest.Models;

namespace DrinkFest.Data.Interface
{
    public interface IDrinkRepository
    {
        IEnumerable<Drinks> Drinks { get; }
        IEnumerable<Drinks> PreferredDrinks { get;}

        Drinks GetDrinkById(int drinkId);
    }
}
