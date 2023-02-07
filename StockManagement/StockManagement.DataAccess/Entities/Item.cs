using System.ComponentModel.DataAnnotations;

namespace StockManagement.DataAccess.Entities
{
    public class Item : EntityBase
    {
        public int? ItemCaseId { get; set; }
        public ItemCase ItemCase { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<Order> Orders { get; set; }
       
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }    
        public int? Price { get; set; }
        public string? Category { get; set; }
        public int? Quantity { get; set; }
    }
}
