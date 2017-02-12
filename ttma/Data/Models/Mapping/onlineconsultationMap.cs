using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class onlineconsultationMap : EntityTypeConfiguration<onlineconsultation>
    {
        public onlineconsultationMap()
        {
            // Primary Key
            this.HasKey(t => t.IDappointement);

            // Properties
            this.Property(t => t.IDappointement)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dateApp)
                .HasMaxLength(255);

            this.Property(t => t.doctorNAmeapp)
                .HasMaxLength(255);

            this.Property(t => t.patientNAmeApp)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("onlineconsultations", "jpadb");
            this.Property(t => t.IDappointement).HasColumnName("IDappointement");
            this.Property(t => t.dateApp).HasColumnName("dateApp");
            this.Property(t => t.doctorNAmeapp).HasColumnName("doctorNAmeapp");
            this.Property(t => t.patientNAmeApp).HasColumnName("patientNAmeApp");
        }
    }
}
