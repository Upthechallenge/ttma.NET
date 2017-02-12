using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class problemdiscussionMap : EntityTypeConfiguration<problemdiscussion>
    {
        public problemdiscussionMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.sender)
                .HasMaxLength(255);

            this.Property(t => t.title)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("problemdiscussion", "jpadb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.sender).HasColumnName("sender");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.problem).HasColumnName("problem");
            this.Property(t => t.user).HasColumnName("user");

            // Relationships
            this.HasOptional(t => t.problem1)
                .WithMany(t => t.problemdiscussions)
                .HasForeignKey(d => d.problem);
            this.HasOptional(t => t.user1)
                .WithMany(t => t.problemdiscussions)
                .HasForeignKey(d => d.user);

        }
    }
}
