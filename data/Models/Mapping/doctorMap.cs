using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using domain.Entities;
namespace data.Models.Mapping
{
    public class doctorMap : EntityTypeConfiguration<doctor>
    {
        public doctorMap()
        {
            // Primary Key
            this.HasKey(t => t.numCinDoc);

            // Properties
            this.Property(t => t.numCinDoc)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.adressDoc)
                .HasMaxLength(255);

            this.Property(t => t.clinic)
                .HasMaxLength(255);

            this.Property(t => t.emailDoc)
                .HasMaxLength(255);

            this.Property(t => t.firsNameDoc)
                .HasMaxLength(255);

            this.Property(t => t.specialityDoc)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("doctor", "jpadb");
            this.Property(t => t.numCinDoc).HasColumnName("numCinDoc");
            this.Property(t => t.adressDoc).HasColumnName("adressDoc");
            this.Property(t => t.clinic).HasColumnName("clinic");
            this.Property(t => t.emailDoc).HasColumnName("emailDoc");
            this.Property(t => t.firsNameDoc).HasColumnName("firsNameDoc");
            this.Property(t => t.nbrYearsOfExp).HasColumnName("nbrYearsOfExp");
            this.Property(t => t.specialityDoc).HasColumnName("specialityDoc");
        }
    }
}
