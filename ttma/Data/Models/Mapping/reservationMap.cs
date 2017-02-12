using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class reservationMap : EntityTypeConfiguration<reservation>
    {
        public reservationMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("reservation", "jpadb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.approvation).HasColumnName("approvation");
            this.Property(t => t.dateReserv).HasColumnName("dateReserv");
            this.Property(t => t.hotel).HasColumnName("hotel");
            this.Property(t => t.user).HasColumnName("user");

            // Relationships
            this.HasOptional(t => t.hotel1)
                .WithMany(t => t.reservations)
                .HasForeignKey(d => d.hotel);
            this.HasOptional(t => t.user1)
                .WithMany(t => t.reservations)
                .HasForeignKey(d => d.user);

        }
    }
}
