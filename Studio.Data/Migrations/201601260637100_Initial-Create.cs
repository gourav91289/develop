namespace com.boutique.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 255),
                        LastName = c.String(maxLength: 255),
                        UserName = c.String(maxLength: 255),
                        Password = c.String(),
                        IsActive = c.Boolean(),
                        ExpireDate = c.DateTime(nullable: false),
                        guid = c.Guid(nullable: false),
                        CreateOn = c.DateTime(nullable: false),
                        LastUpdatedOn = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Butique_BoutiqueId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Boutique", t => t.Butique_BoutiqueId)
                .Index(t => t.Butique_BoutiqueId);
            
            CreateTable(
                "dbo.Boutique",
                c => new
                    {
                        BoutiqueId = c.Int(nullable: false, identity: true),
                        BillStartNumber = c.Int(nullable: false),
                        Name = c.String(maxLength: 255),
                        Address = c.String(),
                        PhoneNumber = c.String(maxLength: 500),
                        LandlineNumber = c.String(maxLength: 500),
                        CreateOn = c.DateTime(nullable: false),
                        LastUpdatedOn = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BoutiqueId);
            
            CreateTable(
                "dbo.ParameterType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        CreateOn = c.DateTime(nullable: false),
                        LastUpdatedOn = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BillNo = c.String(maxLength: 100),
                        DeliveryDate = c.DateTime(nullable: false),
                        CustomerName = c.String(maxLength: 255),
                        ContactNumber = c.String(maxLength: 255),
                        Address = c.String(),
                        StitchingDetails = c.String(),
                        EmbroideryDetails = c.String(),
                        CreateOn = c.DateTime(nullable: false),
                        LastUpdatedOn = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StitchingItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        CreateOn = c.DateTime(nullable: false),
                        LastUpdatedOn = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "Butique_BoutiqueId", "dbo.Boutique");
            DropIndex("dbo.User", new[] { "Butique_BoutiqueId" });
            DropTable("dbo.StitchingItem");
            DropTable("dbo.CustomerDetail");
            DropTable("dbo.ParameterType");
            DropTable("dbo.Boutique");
            DropTable("dbo.User");
        }
    }
}
