using System.ComponentModel.DataAnnotations;

namespace StockManagement.DataAccess.Entities
{
    public class Customer : EntityBase
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get;set; }

    }
}
