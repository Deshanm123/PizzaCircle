using Microsoft.EntityFrameworkCore;
using PizzaCircle.Model;
using PizzaCircle.Pages.Checkout;

namespace PizzaCircle.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options){
            
        }
    }
}
