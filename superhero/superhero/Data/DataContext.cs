using Microsoft.EntityFrameworkCore;
using superhero.Models;


namespace superhero.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-FG0RP6E7\\MSSQLSERVER02;Initial Catalog=Hero;Integrated Security=True;Encrypt=False");
        }

        public DbSet<Hero> Hero { get; set; }
    }
}
