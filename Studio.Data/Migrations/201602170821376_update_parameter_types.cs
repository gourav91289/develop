namespace com.boutique.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_parameter_types : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParameterType", "StitchingItem_Id", c => c.Int());
            CreateIndex("dbo.ParameterType", "StitchingItem_Id");
            AddForeignKey("dbo.ParameterType", "StitchingItem_Id", "dbo.StitchingItem", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParameterType", "StitchingItem_Id", "dbo.StitchingItem");
            DropIndex("dbo.ParameterType", new[] { "StitchingItem_Id" });
            DropColumn("dbo.ParameterType", "StitchingItem_Id");
        }
    }
}
