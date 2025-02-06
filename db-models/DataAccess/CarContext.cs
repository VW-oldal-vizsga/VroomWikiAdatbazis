using System.Drawing;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess
{
    public class CarContext: DbContext
    {
        public DbSet<PastModel> Cars { get; set; }
        public DbSet<Configuration> Configurators { get; set; }
        public DbSet<MainPage> MainPage { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ConfigTransmissionType> TransmissionTypes { get; set; }
        public DbSet<ConfigColor> Colors { get; set; }
        public DbSet<ConfigEngine> Engines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var conStr = "";
                optionsBuilder.UseMySql(conStr, ServerVersion.AutoDetect(conStr));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PastModel>().HasIndex(c => c.Name).IsUnique();
        }


    } 
}
 