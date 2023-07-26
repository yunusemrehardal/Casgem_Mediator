using Microsoft.EntityFrameworkCore;

namespace Casgem_Mediator.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; initial catalog=MediatorDb; integrated security=true");
        }
        public DbSet<Product> Products { get; set; }

        
    }
}
