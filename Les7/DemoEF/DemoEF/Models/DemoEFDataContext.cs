using Microsoft.EntityFrameworkCore;

namespace DemoEF.Models
{
    public class DemoEFDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=(localdb)\MSSQLLocalDB;initial catalog=DemoEF456");
        }

        public DbSet<Persoon> Personen { get; set; }
        public DbSet<Docent> Docenten { get; set; }
        public DbSet<Student> Studenten { get; set; }
        public DbSet<Woonplaats> Woonplaatsen { get; set; }
    }
}
