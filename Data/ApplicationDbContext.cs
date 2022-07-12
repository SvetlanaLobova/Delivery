using Microsoft.EntityFrameworkCore;
using Delivery.Models;

namespace Delivery.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Orders> AppOrders { get; set; }
    }
}
