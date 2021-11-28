using Microsoft.EntityFrameworkCore;
using E_Migrant.App.Dominio;
namespace E_Migrant.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Migrante> Migrante {get; set;}
        public DbSet<ConsultaGrupoAmigosFamiliares> ConsultaGrupoAmigosFamiliares {get; set;}
        public DbSet<ConsultaHistorial> ConsultaHistorial {get; set;}
        public DbSet<ConsultaServicios> ConsultaServicios {get; set;}
        public DbSet<EvaluacionServicio> EvaluacionServicio {get; set;}
        public DbSet<RegistroEntidad> RegistroEntidad {get; set;}
        public DbSet<RegistroOfertaServicios> RegistroOfertaServicios {get; set;}
        

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