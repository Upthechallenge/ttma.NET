using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using domain.Entities;
namespace data.Models.Mapping
{
    public class demandetransportMap : EntityTypeConfiguration<demandetransport>
    {
        public demandetransportMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.decision)
                .HasMaxLength(255);

            this.Property(t => t.destination)
                .HasMaxLength(255);

            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.latitude)
                .HasMaxLength(255);

            this.Property(t => t.longitude)
                .HasMaxLength(255);

            this.Property(t => t.moyenTransport)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.prenom)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("demandetransport", "jpadb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.decision).HasColumnName("decision");
            this.Property(t => t.destination).HasColumnName("destination");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.latitude).HasColumnName("latitude");
            this.Property(t => t.longitude).HasColumnName("longitude");
            this.Property(t => t.moyenTransport).HasColumnName("moyenTransport");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.prenom).HasColumnName("prenom");
        }
    }
}
