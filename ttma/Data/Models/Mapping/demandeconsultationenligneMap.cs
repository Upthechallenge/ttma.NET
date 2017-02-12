using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class demandeconsultationenligneMap : EntityTypeConfiguration<demandeconsultationenligne>
    {
        public demandeconsultationenligneMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dateAppointement)
                .HasMaxLength(255);

            this.Property(t => t.doctor_name)
                .HasMaxLength(255);

            this.Property(t => t.patient_Name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("demandeconsultationenligne", "jpadb");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.dateAppointement).HasColumnName("dateAppointement");
            this.Property(t => t.doctor_name).HasColumnName("doctor_name");
            this.Property(t => t.patient_Name).HasColumnName("patient_Name");
        }
    }
}
