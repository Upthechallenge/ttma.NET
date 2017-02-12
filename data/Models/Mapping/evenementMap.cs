using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using domain.Entities;
namespace data.Models.Mapping
{
    public class evenementMap : EntityTypeConfiguration<evenement>
    {
        public evenementMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_event);

            // Properties
            this.Property(t => t.name_event)
                .HasMaxLength(255);

            this.Property(t => t.place_event)
                .HasMaxLength(255);

            this.Property(t => t.program)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("evenement", "jpadb");
            this.Property(t => t.ID_event).HasColumnName("ID_event");
            this.Property(t => t.date_event).HasColumnName("date_event");
            this.Property(t => t.image).HasColumnName("image");
            this.Property(t => t.name_event).HasColumnName("name_event");
            this.Property(t => t.nbr_de_places).HasColumnName("nbr_de_places");
            this.Property(t => t.nbr_participants).HasColumnName("nbr_participants");
            this.Property(t => t.place_event).HasColumnName("place_event");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.program).HasColumnName("program");
        }
    }
}
