using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class transportcompagnieMap : EntityTypeConfiguration<transportcompagnie>
    {
        public transportcompagnieMap()
        {
            // Primary Key
            this.HasKey(t => t.companyId);

            // Properties
            this.Property(t => t.companyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.companyAdress)
                .HasMaxLength(255);

            this.Property(t => t.companyCategory)
                .HasMaxLength(255);

            this.Property(t => t.companyName)
                .HasMaxLength(255);

            this.Property(t => t.companyResponsable)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("transportcompagnie", "jpadb");
            this.Property(t => t.companyId).HasColumnName("companyId");
            this.Property(t => t.companyAdress).HasColumnName("companyAdress");
            this.Property(t => t.companyCategory).HasColumnName("companyCategory");
            this.Property(t => t.companyCost).HasColumnName("companyCost");
            this.Property(t => t.companyName).HasColumnName("companyName");
            this.Property(t => t.companyResponsable).HasColumnName("companyResponsable");
        }
    }
}
