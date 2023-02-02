using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StockManagement.DataAccess
{
    public class StockManagementStorageContextFactory : IDesignTimeDbContextFactory<StockManagementStorageContext>
    {
        public StockManagementStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StockManagementStorageContext>();
            optionsBuilder.UseSqlServer("Data Source = .\\SQLEXPRESS; Initial Catalog = StockManagementStorage; Integrated Security = True;Encrypt=False;" +
                "TrustServerCertificate=True;MultipleActiveResultSets=True");
            return new StockManagementStorageContext(optionsBuilder.Options);
        }
    }
}
