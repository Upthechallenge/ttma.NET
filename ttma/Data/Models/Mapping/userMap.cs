using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class userMap : EntityTypeConfiguration<user>
    {
        public userMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("user", "jpadb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.name).HasColumnName("name");
        }
    }
}
