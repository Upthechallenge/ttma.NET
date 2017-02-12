using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class congeMap : EntityTypeConfiguration<conge>
    {
        public congeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);
                

            // Properties
            this.Property(t => t.CIN)
                .HasMaxLength(255);

            this.Property(t => t.dateDeb)
                .HasMaxLength(255);

            this.Property(t => t.dateFin)
                .HasMaxLength(255);

            this.Property(t => t.verif)
                .HasMaxLength(255);

            this.Property(t => t.titre)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("conge", "jpadb");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CIN).HasColumnName("CIN");
            this.Property(t => t.dateDeb).HasColumnName("dateDeb");
            this.Property(t => t.dateFin).HasColumnName("dateFin");
            this.Property(t => t.verif).HasColumnName("verif");
            this.Property(t => t.titre).HasColumnName("titre");
        }
    }
}
