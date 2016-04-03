namespace com.boutique.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Table_Add_BoutiqueId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParameterType", "BoutiqueId", c => c.Int(nullable: false));
            AddColumn("dbo.CustomerDetail", "BoutiqueId", c => c.Int(nullable: false));
            AddColumn("dbo.StitchingItem", "BoutiqueId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StitchingItem", "BoutiqueId");
            DropColumn("dbo.CustomerDetail", "BoutiqueId");
            DropColumn("dbo.ParameterType", "BoutiqueId");
        }
    }
}
