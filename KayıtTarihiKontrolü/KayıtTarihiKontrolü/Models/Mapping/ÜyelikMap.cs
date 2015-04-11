using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace KayıtTarihiKontrolü.Models.Mapping
{
    public class ÜyelikMap : EntityTypeConfiguration<Üyelik>
    {
        public ÜyelikMap()
        {
            // Primary Key
            this.HasKey(t => t.Guid);

            // Properties
            this.Property(t => t.Ad)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Soyad)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Üyelik");
            this.Property(t => t.Guid).HasColumnName("Guid");
            this.Property(t => t.Üyelik_Tarih).HasColumnName("Üyelik Tarih");
            this.Property(t => t.ÜyelikYenileme_Tarih).HasColumnName("ÜyelikYenileme Tarih");
            this.Property(t => t.Ad).HasColumnName("Ad");
            this.Property(t => t.Soyad).HasColumnName("Soyad");
        }
    }
}
