using Microsoft.EntityFrameworkCore;
using E_Migrant.App.Dominio;
namespace E_Migrant.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Migrante> Migrante {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = grupo14_emprendedores");
            }
        }
    }
    
}