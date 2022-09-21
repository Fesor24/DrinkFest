using DrinkFest.Data.Interface;
using DrinkFest.Models;

namespace DrinkFest.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> Categories => _context.Categories;
    }
}
