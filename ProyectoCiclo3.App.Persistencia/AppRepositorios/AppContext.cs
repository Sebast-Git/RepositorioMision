using Microsoft.EntityFrameworkCore;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Encomienda> Encomienda { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Servicio> Servicio { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                // optionsBuilder.UseSqlServer("Data Source = proyectoequipo6grupo27.database.windows.net; Initial Catalog = ProyectoCiclo3; User ID=admin_equipo6_grupo27;Password=Misiontic2021**");
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\ MSSQLLocalDB; Initial Catalog = ProyectoCiclo3");


            }
        }
    }
}

