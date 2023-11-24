using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace TEST_API.Entities
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Order> Order { get; set; }
    }
}
