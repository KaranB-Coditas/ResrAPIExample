namespace TestAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewColumnInCustomerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Detail_Id", c => c.Int());
            CreateIndex("dbo.Customers", "Detail_Id");
            AddForeignKey("dbo.Customers", "Detail_Id", "dbo.CustomerDetails", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Detail_Id", "dbo.CustomerDetails");
            DropIndex("dbo.Customers", new[] { "Detail_Id" });
            DropColumn("dbo.Customers", "Detail_Id");
        }
    }
}
