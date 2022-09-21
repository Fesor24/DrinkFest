using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace DrinkFest.Models
{
    public class Order
    {
        [BindNever]
        [Key]
        public int OrderId { get; set; }

        public List<OrderDetail>? OrderLines { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name ="Address Line 1")]
        public string AddressLine1 { get; set; }
        [Required]
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }
        [Required]
        [Display(Name ="Zip Code")]
        [StringLength(10, MinimumLength =4)]
        public string ZipCode { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [BindNever]
        public decimal OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
    }
}
