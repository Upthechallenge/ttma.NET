using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using domain.Entities;
namespace data.Models.Mapping
{
    public class operationMap : EntityTypeConfiguration<operation>
    {
        public operationMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_offre);

            // Properties
            this.Property(t => t.ID_offre)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.date)
                .HasMaxLength(255);

            this.Property(t => t.doctorName)
                .HasMaxLength(255);

            this.Property(t => t.medicCenterNAme)
                .HasMaxLength(255);

            this.Property(t => t.publier)
                .HasMaxLength(255);

            this.Property(t => t.type_Operation)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("operation", "jpadb");
            this.Property(t => t.ID_offre).HasColumnName("ID_offre");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.doctorName).HasColumnName("doctorName");
            this.Property(t => t.medicCenterNAme).HasColumnName("medicCenterNAme");
            this.Property(t => t.price_Operation).HasColumnName("price_Operation");
            this.Property(t => t.publier).HasColumnName("publier");
            this.Property(t => t.type_Operation).HasColumnName("type_Operation");
        }
    }
}
