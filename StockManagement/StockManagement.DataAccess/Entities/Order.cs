using System.ComponentModel.DataAnnotations;

namespace StockManagement.DataAccess.Entities
{
    public class Order : EntityBase
    {
   
        public Item Item { get; set; }
        public int ItemId { get; set; }
        public Employee employee { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


        [Required]
        [MaxLength(250)]
        public int Number { get; set; }

    }
}
