namespace StockManagement.DataAccess.Entities
{
    public class ItemCase : EntityBase
    {
        public int Number { get; set; }
        public List<Item> Items { get; set; }
    }
}
