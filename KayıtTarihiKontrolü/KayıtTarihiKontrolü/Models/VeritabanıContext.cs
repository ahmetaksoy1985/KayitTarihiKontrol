using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using KayıtTarihiKontrolü.Models.Mapping;

namespace KayıtTarihiKontrolü.Models
{
    public partial class VeritabanıContext : DbContext
    {
        static VeritabanıContext()
        {
            Database.SetInitializer<VeritabanıContext>(new CreateDatabaseIfNotExists<VeritabanıContext>());
        }

        public VeritabanıContext()
            : base("Name=VeritabanıContext")
        {
        }

        public DbSet<Üyelik> Üyelik { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ÜyelikMap());
        }
    }
}
