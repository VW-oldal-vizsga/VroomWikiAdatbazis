using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess
{
    public class CarContext: DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Configurator> Configurators{ get; set; }
        public DbSet<Extra> Extras{ get; set; }
        public DbSet<MainPage> MainPage { get; set; }
        public DbSet<Sale> Sales{ get; set; }
        public DbSet<User> Users{ get; set; }

        public CarContext() { }

        public CarContext(DbContextOptions<CarContext> options) : base(options) { }

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
            modelBuilder.Entity<Car>().HasIndex(c => c.Name).IsUnique();
        }


    } 
}
 