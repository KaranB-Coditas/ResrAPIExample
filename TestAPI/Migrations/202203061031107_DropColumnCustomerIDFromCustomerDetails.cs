namespace TestAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropColumnCustomerIDFromCustomerDetails : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CustomerDetails", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerDetails", "CustomerId", c => c.Int(nullable: false));
        }
    }
}
