using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using domain.Entities;
namespace data.Models.Mapping
{
    public class timetableMap : EntityTypeConfiguration<timetable>
    {
        public timetableMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.friday)
                .HasMaxLength(255);

            this.Property(t => t.friday1)
                .HasMaxLength(255);

            this.Property(t => t.monday)
                .HasMaxLength(255);

            this.Property(t => t.monday1)
                .HasMaxLength(255);

            this.Property(t => t.thursday)
                .HasMaxLength(255);

            this.Property(t => t.thursday1)
                .HasMaxLength(255);

            this.Property(t => t.tuesday)
                .HasMaxLength(255);

            this.Property(t => t.tuesday1)
                .HasMaxLength(255);

            this.Property(t => t.typeU)
                .HasMaxLength(255);

            this.Property(t => t.wednesday)
                .HasMaxLength(255);

            this.Property(t => t.wednesday1)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("timetable", "jpadb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.friday).HasColumnName("friday");
            this.Property(t => t.friday1).HasColumnName("friday1");
            this.Property(t => t.monday).HasColumnName("monday");
            this.Property(t => t.monday1).HasColumnName("monday1");
            this.Property(t => t.thursday).HasColumnName("thursday");
            this.Property(t => t.thursday1).HasColumnName("thursday1");
            this.Property(t => t.tuesday).HasColumnName("tuesday");
            this.Property(t => t.tuesday1).HasColumnName("tuesday1");
            this.Property(t => t.typeU).HasColumnName("typeU");
            this.Property(t => t.wednesday).HasColumnName("wednesday");
            this.Property(t => t.wednesday1).HasColumnName("wednesday1");
        }
    }
}
