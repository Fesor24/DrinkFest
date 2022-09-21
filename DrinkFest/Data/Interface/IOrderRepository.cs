using DrinkFest.Models;

namespace DrinkFest.Data.Interface
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
