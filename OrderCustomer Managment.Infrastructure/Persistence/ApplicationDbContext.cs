using Microsoft.EntityFrameworkCore;
using OrderCustomer_Managment.Domain.Entities;

namespace OrderCustomer_Managment.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    //en esta clase use ayuda de gemini ya que el constructor me arrojaba error de tipado
    // y era que habia olvidado realizar herencia de la interfaz DbContext para acceder a las funcionalidades de EF Core
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
