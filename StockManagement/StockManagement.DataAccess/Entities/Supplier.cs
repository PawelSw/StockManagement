using System.ComponentModel.DataAnnotations;

namespace StockManagement.DataAccess.Entities
{
    public class Supplier : EntityBase
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        public List<Item> Items { get; set; }
    }
}
