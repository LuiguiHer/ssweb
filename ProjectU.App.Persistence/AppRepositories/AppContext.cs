using Microsoft.EntityFrameworkCore;
using ProjectU.App.Domain;
 
namespace ProjectU.App.Persistence
{
    public class AppContext: DbContext{
        public DbSet<Package> Package { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Service> Service { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source=190.251.240.96,1433;Initial Catalog=ProjectCicle3;User ID=hernandez;Password=Luchodb1*;");
            }
        }
    }
}
