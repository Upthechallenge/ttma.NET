using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class hotelMap : EntityTypeConfiguration<hotel>
    {
        public hotelMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.adresse)
                .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.latitude)
                .HasMaxLength(255);

            this.Property(t => t.longitude)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("hotel", "jpadb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.adresse).HasColumnName("adresse");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.latitude).HasColumnName("latitude");
            this.Property(t => t.longitude).HasColumnName("longitude");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.pic).HasColumnName("pic");
            this.Property(t => t.roomNumber).HasColumnName("roomNumber");
            this.Property(t => t.star).HasColumnName("star");
        }
    }
}
