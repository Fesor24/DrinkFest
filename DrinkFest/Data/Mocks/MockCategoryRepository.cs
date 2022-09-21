using DrinkFest.Data.Interface;
using DrinkFest.Models;

namespace DrinkFest.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories {
            get {
                return new List<Category> {
                new Category {CategoryName= "Alcoholic", Description="All alcoholic drinks"},
                new Category {CategoryName= "Non-Alcoholic", Description = "All non-alcoholic drinks"}

                };
            
            }
        }
    }
}
