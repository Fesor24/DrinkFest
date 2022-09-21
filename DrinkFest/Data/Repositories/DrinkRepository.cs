using DrinkFest.Data.Interface;
using DrinkFest.Models;
using Microsoft.EntityFrameworkCore;

namespace DrinkFest.Data.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext _context;
        public DrinkRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Drinks> Drinks => _context.Drinks.Include(c => c.Category);


        public IEnumerable<Drinks> PreferredDrinks => _context.Drinks.Where(p => p.isPreferredDrink).Include(c => c.Category);

        public Drinks GetDrinkById(int drinkId) => _context.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
        
    }
}
