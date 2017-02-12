namespace data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jpadb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "jpadb.conge",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CIN = c.String(maxLength: 255, storeType: "nvarchar"),
                        dateDeb = c.String(maxLength: 255, storeType: "nvarchar"),
                        dateFin = c.String(maxLength: 255, storeType: "nvarchar"),
                        verif = c.String(maxLength: 255, storeType: "nvarchar"),
                        titre = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "jpadb.demandeconsultationenligne",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        dateAppointement = c.String(maxLength: 255, storeType: "nvarchar"),
                        doctor_name = c.String(maxLength: 255, storeType: "nvarchar"),
                        patient_Name = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "jpadb.demande",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        decision = c.String(maxLength: 255, storeType: "nvarchar"),
                        destination = c.String(maxLength: 255, storeType: "nvarchar"),
                        email = c.String(maxLength: 255, storeType: "nvarchar"),
                        latitude = c.String(maxLength: 255, storeType: "nvarchar"),
                        longitude = c.String(maxLength: 255, storeType: "nvarchar"),
                        moyenTransport = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        prenom = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "jpadb.demandetransport",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        decision = c.String(maxLength: 255, storeType: "nvarchar"),
                        destination = c.String(maxLength: 255, storeType: "nvarchar"),
                        email = c.String(maxLength: 255, storeType: "nvarchar"),
                        latitude = c.String(maxLength: 255, storeType: "nvarchar"),
                        longitude = c.String(maxLength: 255, storeType: "nvarchar"),
                        moyenTransport = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        prenom = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "jpadb.doctordisponibilities",
                c => new
                    {
                        ID_disp = c.Int(nullable: false),
                        date_disp = c.String(maxLength: 255, storeType: "nvarchar"),
                        doctor_name = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID_disp);
            
            CreateTable(
                "jpadb.doctor",
                c => new
                    {
                        numCinDoc = c.Int(nullable: false),
                        adressDoc = c.String(maxLength: 255, storeType: "nvarchar"),
                        clinic = c.String(maxLength: 255, storeType: "nvarchar"),
                        emailDoc = c.String(maxLength: 255, storeType: "nvarchar"),
                        firsNameDoc = c.String(maxLength: 255, storeType: "nvarchar"),
                        nbrYearsOfExp = c.Int(nullable: false),
                        specialityDoc = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.numCinDoc);
            
            CreateTable(
                "jpadb.evenement",
                c => new
                    {
                        ID_event = c.Int(nullable: false, identity: true),
                        date_event = c.DateTime(precision: 0),
                        image = c.Binary(),
                        name_event = c.String(maxLength: 255, storeType: "nvarchar"),
                        nbr_de_places = c.Int(),
                        nbr_participants = c.Int(),
                        place_event = c.String(maxLength: 255, storeType: "nvarchar"),
                        price = c.Single(nullable: false),
                        program = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID_event);
            
            CreateTable(
                "jpadb.hotel",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        adresse = c.String(maxLength: 255, storeType: "nvarchar"),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        latitude = c.String(maxLength: 255, storeType: "nvarchar"),
                        longitude = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        pic = c.Binary(),
                        roomNumber = c.Int(),
                        star = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "jpadb.reservation",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        approvation = c.Boolean(),
                        dateReserv = c.DateTime(precision: 0),
                        hotel = c.Int(),
                        user = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("jpadb.hotel", t => t.hotel)
                .ForeignKey("jpadb.user", t => t.user)
                .Index(t => t.hotel)
                .Index(t => t.user);
            
            CreateTable(
                "jpadb.user",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        email = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "jpadb.problemdiscussion",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(precision: 0),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        sender = c.String(maxLength: 255, storeType: "nvarchar"),
                        title = c.String(maxLength: 255, storeType: "nvarchar"),
                        problem = c.Int(),
                        user = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("jpadb.problem", t => t.problem)
                .ForeignKey("jpadb.user", t => t.user)
                .Index(t => t.problem)
                .Index(t => t.user);
            
            CreateTable(
                "jpadb.problem",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(precision: 0),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        resolved = c.Boolean(),
                        title = c.String(maxLength: 255, storeType: "nvarchar"),
                        user = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("jpadb.user", t => t.user)
                .Index(t => t.user);
            
            CreateTable(
                "jpadb.insurance_offer",
                c => new
                    {
                        id_insurance = c.Int(nullable: false, identity: true),
                        description = c.String(maxLength: 45, storeType: "nvarchar"),
                        price = c.String(maxLength: 50, storeType: "nvarchar"),
                        insurer_id_user = c.Int(),
                        image = c.String(unicode: false),
                        Rating = c.Int(nullable: false),
                        TotalRaters = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_insurance)
                .ForeignKey("jpadb.staff", t => t.insurer_id_user)
                .Index(t => t.insurer_id_user);
            
            CreateTable(
                "jpadb.staff",
                c => new
                    {
                        id = c.Int(nullable: false),
                        cin = c.String(maxLength: 255, storeType: "nvarchar"),
                        dns = c.DateTime(precision: 0),
                        e_mail = c.String(maxLength: 255, storeType: "nvarchar"),
                        function = c.String(maxLength: 255, storeType: "nvarchar"),
                        login = c.String(maxLength: 255, storeType: "nvarchar"),
                        mdp = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        insurance_agency = c.String(maxLength: 45, storeType: "nvarchar"),
                        salaire = c.Single(nullable: false),
                        surname = c.String(maxLength: 255, storeType: "nvarchar"),
                        DTYPE = c.String(maxLength: 45, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "jpadb.medicalcenters",
                c => new
                    {
                        ID_Med_center = c.Int(nullable: false),
                        adress_Med_center = c.String(maxLength: 255, storeType: "nvarchar"),
                        conventionne = c.String(maxLength: 255, storeType: "nvarchar"),
                        name_Med_center = c.String(maxLength: 255, storeType: "nvarchar"),
                        resp_Med_center = c.String(maxLength: 255, storeType: "nvarchar"),
                        speciality_Med_center = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID_Med_center);
            
            CreateTable(
                "jpadb.onlineconsultations",
                c => new
                    {
                        IDappointement = c.Int(nullable: false),
                        dateApp = c.String(maxLength: 255, storeType: "nvarchar"),
                        doctorNAmeapp = c.String(maxLength: 255, storeType: "nvarchar"),
                        patientNAmeApp = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IDappointement);
            
            CreateTable(
                "jpadb.operation",
                c => new
                    {
                        ID_offre = c.Int(nullable: false, identity: true),
                        date = c.String(maxLength: 255, storeType: "nvarchar"),
                        doctorName = c.String(maxLength: 255, storeType: "nvarchar"),
                        medicCenterNAme = c.String(maxLength: 255, storeType: "nvarchar"),
                        price_Operation = c.Single(nullable: false),
                        publier = c.String(maxLength: 255, storeType: "nvarchar"),
                        type_Operation = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID_offre);
            
            CreateTable(
                "jpadb.timetable",
                c => new
                    {
                        id = c.Int(nullable: false),
                        friday = c.String(maxLength: 255, storeType: "nvarchar"),
                        friday1 = c.String(maxLength: 255, storeType: "nvarchar"),
                        monday = c.String(maxLength: 255, storeType: "nvarchar"),
                        monday1 = c.String(maxLength: 255, storeType: "nvarchar"),
                        thursday = c.String(maxLength: 255, storeType: "nvarchar"),
                        thursday1 = c.String(maxLength: 255, storeType: "nvarchar"),
                        tuesday = c.String(maxLength: 255, storeType: "nvarchar"),
                        tuesday1 = c.String(maxLength: 255, storeType: "nvarchar"),
                        typeU = c.String(maxLength: 255, storeType: "nvarchar"),
                        wednesday = c.String(maxLength: 255, storeType: "nvarchar"),
                        wednesday1 = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "jpadb.transportcompagnie",
                c => new
                    {
                        companyId = c.Int(nullable: false),
                        companyAdress = c.String(maxLength: 255, storeType: "nvarchar"),
                        companyCategory = c.String(maxLength: 255, storeType: "nvarchar"),
                        companyCost = c.Single(nullable: false),
                        companyName = c.String(maxLength: 255, storeType: "nvarchar"),
                        companyResponsable = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.companyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("jpadb.insurance_offer", "insurer_id_user", "jpadb.staff");
            DropForeignKey("jpadb.reservation", "user", "jpadb.user");
            DropForeignKey("jpadb.problemdiscussion", "user", "jpadb.user");
            DropForeignKey("jpadb.problemdiscussion", "problem", "jpadb.problem");
            DropForeignKey("jpadb.problem", "user", "jpadb.user");
            DropForeignKey("jpadb.reservation", "hotel", "jpadb.hotel");
            DropIndex("jpadb.insurance_offer", new[] { "insurer_id_user" });
            DropIndex("jpadb.problem", new[] { "user" });
            DropIndex("jpadb.problemdiscussion", new[] { "user" });
            DropIndex("jpadb.problemdiscussion", new[] { "problem" });
            DropIndex("jpadb.reservation", new[] { "user" });
            DropIndex("jpadb.reservation", new[] { "hotel" });
            DropTable("jpadb.transportcompagnie");
            DropTable("jpadb.timetable");
            DropTable("jpadb.operation");
            DropTable("jpadb.onlineconsultations");
            DropTable("jpadb.medicalcenters");
            DropTable("jpadb.staff");
            DropTable("jpadb.insurance_offer");
            DropTable("jpadb.problem");
            DropTable("jpadb.problemdiscussion");
            DropTable("jpadb.user");
            DropTable("jpadb.reservation");
            DropTable("jpadb.hotel");
            DropTable("jpadb.evenement");
            DropTable("jpadb.doctor");
            DropTable("jpadb.doctordisponibilities");
            DropTable("jpadb.demandetransport");
            DropTable("jpadb.demande");
            DropTable("jpadb.demandeconsultationenligne");
            DropTable("jpadb.conge");
        }
    }
}
