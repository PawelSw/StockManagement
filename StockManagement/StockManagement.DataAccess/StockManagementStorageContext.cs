using Microsoft.EntityFrameworkCore;
using StockManagement.DataAccess.Entities;


namespace StockManagement.DataAccess
{
    public class StockManagementStorageContext : DbContext
    {
        public StockManagementStorageContext(DbContextOptions<StockManagementStorageContext> options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCase> ItemCases { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }


    }
}
