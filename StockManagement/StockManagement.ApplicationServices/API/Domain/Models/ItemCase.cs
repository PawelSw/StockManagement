namespace StockManagement.ApplicationServices.API.Domain.Models
{
    public class ItemCase
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public List<string> ItemNames { get; set; }
       
    }
}
