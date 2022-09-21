using System.ComponentModel.DataAnnotations;

namespace DrinkFest.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int DrinkId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Drinks Drink  { get; set; }
        public virtual Order Order { get; set; }
    }
}
