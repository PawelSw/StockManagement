using System.ComponentModel.DataAnnotations;

namespace StockManagement.DataAccess.Entities
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
