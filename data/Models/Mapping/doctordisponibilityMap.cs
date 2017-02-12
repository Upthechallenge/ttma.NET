using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using domain.Entities;
namespace data.Models.Mapping
{
    public class doctordisponibilityMap : EntityTypeConfiguration<doctordisponibility>
    {
        public doctordisponibilityMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_disp);

            // Properties
            this.Property(t => t.ID_disp)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.date_disp)
                .HasMaxLength(255);

            this.Property(t => t.doctor_name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("doctordisponibilities", "jpadb");
            this.Property(t => t.ID_disp).HasColumnName("ID_disp");
            this.Property(t => t.date_disp).HasColumnName("date_disp");
            this.Property(t => t.doctor_name).HasColumnName("doctor_name");
        }
    }
}
