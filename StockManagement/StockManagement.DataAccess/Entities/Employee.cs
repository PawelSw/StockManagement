using System.ComponentModel.DataAnnotations;

namespace StockManagement.DataAccess.Entities
{
    public class Employee : EntityBase
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        List<Order> Orders { get; set;}
    }
}
