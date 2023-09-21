using Microsoft.EntityFrameworkCore;
using PizzaCircle.Model;

namespace PizzaCircle.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(){
            
        }
    }
}
