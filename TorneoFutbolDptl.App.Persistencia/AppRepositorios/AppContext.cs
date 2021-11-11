using Microsoft.EntityFrameworkCore;
using TorneoFutbolDptl.App.Dominio;
namespace TorneoFutbolDptl.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Arbitro> Arbitros{get; set;}
        public DbSet<DesempenoEquipo> DesempenoEquipos{get; set;}
        public DbSet<DirectorTecnico> DirectorTecnicos{get; set;}
        public DbSet<Equipo> Equipos{get; set;}
        public DbSet<Estadio> Estadios {get; set;}
        public DbSet<Jugador> Jugadores{get; set;}
        public DbSet<Municipio> Municipios{get; set;}
        public DbSet<Novedad> Novedades{get; set;}
        public DbSet<Partido> Partidos{get; set;}
        public DbSet<Posicion> Posiciones{get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TorneoFutbolDptlData");
                
            } 
        }           

    }
}
