using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using domain.Entities;
namespace data.Models.Mapping
{
    public class problemMap : EntityTypeConfiguration<problem>
    {
        public problemMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.title)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("problem", "jpadb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.resolved).HasColumnName("resolved");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.user).HasColumnName("user");

            // Relationships
            this.HasOptional(t => t.user1)
                .WithMany(t => t.problems)
                .HasForeignKey(d => d.user);

        }
    }
}
