namespace RestoDDD.infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Resto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Commentaire",
                c => new
                    {
                        CommentaireId = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Compte_CompteId = c.Int(),
                        Restaurant_RestaurantId = c.Int(),
                    })
                .PrimaryKey(t => t.CommentaireId)
                .ForeignKey("dbo.Compte", t => t.Compte_CompteId)
                .ForeignKey("dbo.Restaurant", t => t.Restaurant_RestaurantId)
                .Index(t => t.Compte_CompteId)
                .Index(t => t.Restaurant_RestaurantId);
            
            CreateTable(
                "dbo.Compte",
                c => new
                    {
                        CompteId = c.Int(nullable: false, identity: true),
                        Login = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        IsAdmin = c.Boolean(nullable: false),
                        Nom = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Prenom = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Email = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Adresse = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        NumTel = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.CompteId);
            
            CreateTable(
                "dbo.Reservation",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        NombrePres = c.Int(nullable: false),
                        ResvDate = c.DateTime(nullable: false, precision: 0),
                        Compte_CompteId = c.Int(),
                        Restaurant_RestaurantId = c.Int(),
                    })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Compte", t => t.Compte_CompteId)
                .ForeignKey("dbo.Restaurant", t => t.Restaurant_RestaurantId)
                .Index(t => t.Compte_CompteId)
                .Index(t => t.Restaurant_RestaurantId);
            
            CreateTable(
                "dbo.Restaurant",
                c => new
                    {
                        RestaurantId = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 150, storeType: "nvarchar"),
                        Adresse = c.String(nullable: false, unicode: false),
                        Description = c.String(nullable: false, maxLength: 300, storeType: "nvarchar"),
                        MotBienvenu = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Slogon = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Lieu = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Fax = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        region = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        specialite = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Telephone = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.RestaurantId);
            
            CreateTable(
                "dbo.Cuisine",
                c => new
                    {
                        CuisineID = c.Int(nullable: false, identity: true),
                        typeCuisine = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Description = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Image = c.String(nullable: false, unicode: false),
                        Restaurant_RestaurantId = c.Int(),
                    })
                .PrimaryKey(t => t.CuisineID)
                .ForeignKey("dbo.Restaurant", t => t.Restaurant_RestaurantId)
                .Index(t => t.Restaurant_RestaurantId);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        MenuId = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Prix = c.Double(nullable: false),
                        Description = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Restaurant_RestaurantId = c.Int(),
                        Cuisine_CuisineID = c.Int(),
                    })
                .PrimaryKey(t => t.MenuId)
                .ForeignKey("dbo.Restaurant", t => t.Restaurant_RestaurantId)
                .ForeignKey("dbo.Cuisine", t => t.Cuisine_CuisineID)
                .Index(t => t.Restaurant_RestaurantId)
                .Index(t => t.Cuisine_CuisineID);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImagesId = c.Int(nullable: false, identity: true),
                        Nom = c.String(unicode: false),
                        Categorie = c.String(unicode: false),
                        Restaurant_RestaurantId = c.Int(),
                    })
                .PrimaryKey(t => t.ImagesId)
                .ForeignKey("dbo.Restaurant", t => t.Restaurant_RestaurantId)
                .Index(t => t.Restaurant_RestaurantId);
            
            CreateTable(
                "dbo.Note",
                c => new
                    {
                        NoteId = c.Int(nullable: false, identity: true),
                        NoteR = c.Double(nullable: false),
                        Restaurant_RestaurantId = c.Int(),
                    })
                .PrimaryKey(t => t.NoteId)
                .ForeignKey("dbo.Restaurant", t => t.Restaurant_RestaurantId)
                .Index(t => t.Restaurant_RestaurantId);
            
            CreateTable(
                "dbo.Table",
                c => new
                    {
                        TableId = c.Int(nullable: false, identity: true),
                        NombrePers = c.Int(nullable: false),
                        Etat = c.Boolean(nullable: false),
                        Restaurant_RestaurantId = c.Int(),
                    })
                .PrimaryKey(t => t.TableId)
                .ForeignKey("dbo.Restaurant", t => t.Restaurant_RestaurantId)
                .Index(t => t.Restaurant_RestaurantId);
            
            CreateTable(
                "dbo.Facture",
                c => new
                    {
                        FactureId = c.Int(nullable: false, identity: true),
                        Reservation_ReservationId = c.Int(),
                    })
                .PrimaryKey(t => t.FactureId)
                .ForeignKey("dbo.Reservation", t => t.Reservation_ReservationId)
                .Index(t => t.Reservation_ReservationId);
            
            CreateTable(
                "dbo.GeoCoord",
                c => new
                    {
                        GeoCoordId = c.Int(nullable: false, identity: true),
                        Longitude = c.Double(nullable: false),
                        Latitude = c.Double(nullable: false),
                        Restaurant_RestaurantId = c.Int(),
                    })
                .PrimaryKey(t => t.GeoCoordId)
                .ForeignKey("dbo.Restaurant", t => t.Restaurant_RestaurantId)
                .Index(t => t.Restaurant_RestaurantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GeoCoord", "Restaurant_RestaurantId", "dbo.Restaurant");
            DropForeignKey("dbo.Facture", "Reservation_ReservationId", "dbo.Reservation");
            DropForeignKey("dbo.Table", "Restaurant_RestaurantId", "dbo.Restaurant");
            DropForeignKey("dbo.Reservation", "Restaurant_RestaurantId", "dbo.Restaurant");
            DropForeignKey("dbo.Note", "Restaurant_RestaurantId", "dbo.Restaurant");
            DropForeignKey("dbo.Images", "Restaurant_RestaurantId", "dbo.Restaurant");
            DropForeignKey("dbo.Cuisine", "Restaurant_RestaurantId", "dbo.Restaurant");
            DropForeignKey("dbo.Menu", "Cuisine_CuisineID", "dbo.Cuisine");
            DropForeignKey("dbo.Menu", "Restaurant_RestaurantId", "dbo.Restaurant");
            DropForeignKey("dbo.Commentaire", "Restaurant_RestaurantId", "dbo.Restaurant");
            DropForeignKey("dbo.Reservation", "Compte_CompteId", "dbo.Compte");
            DropForeignKey("dbo.Commentaire", "Compte_CompteId", "dbo.Compte");
            DropIndex("dbo.GeoCoord", new[] { "Restaurant_RestaurantId" });
            DropIndex("dbo.Facture", new[] { "Reservation_ReservationId" });
            DropIndex("dbo.Table", new[] { "Restaurant_RestaurantId" });
            DropIndex("dbo.Note", new[] { "Restaurant_RestaurantId" });
            DropIndex("dbo.Images", new[] { "Restaurant_RestaurantId" });
            DropIndex("dbo.Menu", new[] { "Cuisine_CuisineID" });
            DropIndex("dbo.Menu", new[] { "Restaurant_RestaurantId" });
            DropIndex("dbo.Cuisine", new[] { "Restaurant_RestaurantId" });
            DropIndex("dbo.Reservation", new[] { "Restaurant_RestaurantId" });
            DropIndex("dbo.Reservation", new[] { "Compte_CompteId" });
            DropIndex("dbo.Commentaire", new[] { "Restaurant_RestaurantId" });
            DropIndex("dbo.Commentaire", new[] { "Compte_CompteId" });
            DropTable("dbo.GeoCoord");
            DropTable("dbo.Facture");
            DropTable("dbo.Table");
            DropTable("dbo.Note");
            DropTable("dbo.Images");
            DropTable("dbo.Menu");
            DropTable("dbo.Cuisine");
            DropTable("dbo.Restaurant");
            DropTable("dbo.Reservation");
            DropTable("dbo.Compte");
            DropTable("dbo.Commentaire");
        }
    }
}
