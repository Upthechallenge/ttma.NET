using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using domain.Entities;
namespace data.Models.Mapping
{
    public class medicalcenterMap : EntityTypeConfiguration<medicalcenter>
    {
        public medicalcenterMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Med_center);

            // Properties
            this.Property(t => t.ID_Med_center)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.adress_Med_center)
                .HasMaxLength(255);

            this.Property(t => t.conventionne)
                .HasMaxLength(255);

            this.Property(t => t.name_Med_center)
                .HasMaxLength(255);

            this.Property(t => t.resp_Med_center)
                .HasMaxLength(255);

            this.Property(t => t.speciality_Med_center)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("medicalcenters", "jpadb");
            this.Property(t => t.ID_Med_center).HasColumnName("ID_Med_center");
            this.Property(t => t.adress_Med_center).HasColumnName("adress_Med_center");
            this.Property(t => t.conventionne).HasColumnName("conventionne");
            this.Property(t => t.name_Med_center).HasColumnName("name_Med_center");
            this.Property(t => t.resp_Med_center).HasColumnName("resp_Med_center");
            this.Property(t => t.speciality_Med_center).HasColumnName("speciality_Med_center");
        }
    }
}
