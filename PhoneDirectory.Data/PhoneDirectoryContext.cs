using Microsoft.EntityFrameworkCore;
using PhoneDirectory.Data.Entities;

namespace PhoneDirectory.Data
{
    public class PhoneDirectoryContext : DbContext
    {
        public PhoneDirectoryContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Communication> Communications { get; set; }

      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PhoneDirectoryContext).Assembly);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var connectionString = "Server=localhost;Port=5432;Database=PostgreSqlExample;User Id=sa;Password=12345;Integrated Security=true;Pooling=true;";
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseNpgsql(connectionString);
        //}
    }
}
