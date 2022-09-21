using DrinkFest.Models;

namespace DrinkFest.Data.Interface
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
