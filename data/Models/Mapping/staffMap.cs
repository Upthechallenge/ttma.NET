using domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace data.Models.Mapping
{
    public class staffMap : EntityTypeConfiguration<staff>
    {
        public staffMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cin)
                .HasMaxLength(255);

            this.Property(t => t.e_mail)
                .HasMaxLength(255);

            this.Property(t => t.function)
                .HasMaxLength(255);

            this.Property(t => t.login)
                .HasMaxLength(255);

            this.Property(t => t.mdp)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.surname)
                .HasMaxLength(255);

            this.Property(t => t.DTYPE)
                .HasMaxLength(45);

            this.Property(t => t.insurance_agency)
                .HasMaxLength(45);

            // Table & Column Mappings
            this.ToTable("staff", "jpadb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.cin).HasColumnName("cin");
            this.Property(t => t.dns).HasColumnName("dns");
            this.Property(t => t.e_mail).HasColumnName("e_mail");
            this.Property(t => t.function).HasColumnName("function");
            this.Property(t => t.login).HasColumnName("login");
            this.Property(t => t.mdp).HasColumnName("mdp");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.salaire).HasColumnName("salaire");
            this.Property(t => t.surname).HasColumnName("surname");
            this.Property(t => t.DTYPE).HasColumnName("DTYPE");
            this.Property(t => t.insurance_agency).HasColumnName("insurance_agency");
        }
    }
}
