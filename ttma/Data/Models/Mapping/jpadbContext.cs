using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Data.Models.Mapping;

namespace Data.Models
{
    public partial class jpadbContext : DbContext
    {
        static jpadbContext()
        {
            Database.SetInitializer<jpadbContext>(null);
        }

        public jpadbContext()
            : base("Name=jpadbContext")
        {
        }

        public DbSet<conge> conges { get; set; }
        public DbSet<demande> demandes { get; set; }
        public DbSet<demandeconsultationenligne> demandeconsultationenlignes { get; set; }
        public DbSet<demandetransport> demandetransports { get; set; }
        public DbSet<doctor> doctors { get; set; }
        public DbSet<doctordisponibility> doctordisponibilities { get; set; }
        public DbSet<evenement> evenements { get; set; }
        public DbSet<hotel> hotels { get; set; }
        public DbSet<medicalcenter> medicalcenters { get; set; }
        public DbSet<onlineconsultation> onlineconsultations { get; set; }
        public DbSet<operation> operations { get; set; }
        public DbSet<problem> problems { get; set; }
        public DbSet<problemdiscussion> problemdiscussions { get; set; }
        public DbSet<reservation> reservations { get; set; }
        public DbSet<staff> staffs { get; set; }
        public DbSet<transportcompagnie> transportcompagnies { get; set; }
        public DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new congeMap());
            modelBuilder.Configurations.Add(new demandeMap());
            modelBuilder.Configurations.Add(new demandeconsultationenligneMap());
            modelBuilder.Configurations.Add(new demandetransportMap());
            modelBuilder.Configurations.Add(new doctorMap());
            modelBuilder.Configurations.Add(new doctordisponibilityMap());
            modelBuilder.Configurations.Add(new evenementMap());
            modelBuilder.Configurations.Add(new hotelMap());
            modelBuilder.Configurations.Add(new medicalcenterMap());
            modelBuilder.Configurations.Add(new onlineconsultationMap());
            modelBuilder.Configurations.Add(new operationMap());
            modelBuilder.Configurations.Add(new problemMap());
            modelBuilder.Configurations.Add(new problemdiscussionMap());
            modelBuilder.Configurations.Add(new reservationMap());
            modelBuilder.Configurations.Add(new staffMap());
            modelBuilder.Configurations.Add(new transportcompagnieMap());
            modelBuilder.Configurations.Add(new userMap());
        }
    }
}
