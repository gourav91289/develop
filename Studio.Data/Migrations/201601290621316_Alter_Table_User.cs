namespace com.boutique.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Table_User : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.User", name: "Butique_BoutiqueId", newName: "boutique_BoutiqueId");
            RenameIndex(table: "dbo.User", name: "IX_Butique_BoutiqueId", newName: "IX_boutique_BoutiqueId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.User", name: "IX_boutique_BoutiqueId", newName: "IX_Butique_BoutiqueId");
            RenameColumn(table: "dbo.User", name: "boutique_BoutiqueId", newName: "Butique_BoutiqueId");
        }
    }
}
