using domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace data.Models.Mapping
{
    public class insurance_offerMap : EntityTypeConfiguration<insurance_offer>
    {
        public insurance_offerMap()
        {
            // Primary Key
            this.HasKey(t => t.id_insurance);
            this.Property(t => t.id_insurance)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(45);

            this.Property(t => t.price)
                .HasMaxLength(45);

            this.Property(t => t.price)
                .HasMaxLength(50);
            

            // Table & Column Mappings
            this.ToTable("insurance_offer", "jpadb");
            this.Property(t => t.id_insurance).HasColumnName("id_insurance");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.insurer_id_user).HasColumnName("insurer_id_user");
            this.Property(t => t.image).HasColumnName("image");
            this.Property(t => t.TotalRaters).HasColumnName("TotalRaters");
            this.Property(t => t.Rating).HasColumnName("Rating");

            // Relationships
            this.HasOptional(t => t.staff)
                .WithMany(t => t.insurance_offer)
                .HasForeignKey(d => d.insurer_id_user);

        }
    }
}
