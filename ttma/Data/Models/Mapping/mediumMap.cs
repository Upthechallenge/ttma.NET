using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class mediumMap : EntityTypeConfiguration<medium>
    {
        public mediumMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Titre)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.SousTitre)
                .HasMaxLength(45);

            this.Property(t => t.Resume)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("media", "media");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Titre).HasColumnName("Titre");
            this.Property(t => t.SousTitre).HasColumnName("SousTitre");
            this.Property(t => t.Resume).HasColumnName("Resume");
            this.Property(t => t.IdAuteur).HasColumnName("IdAuteur");
            //Inheritance
            Map<Livre>(c => {
                c.Requires("IsLivre").HasValue(1);
            });
            Map<CD>(c =>
            {
                c.Requires("IsLivre").HasValue(0);
            });
           
           

        }
    }
}
