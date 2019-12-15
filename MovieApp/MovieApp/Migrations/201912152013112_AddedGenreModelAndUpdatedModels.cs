namespace MovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenreModelAndUpdatedModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "StockNumber", c => c.Short(nullable: false));
            AlterColumn("dbo.Customers", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "BirthDate", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "BirthDate", c => c.String());
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
            DropColumn("dbo.Movies", "StockNumber");
        }
    }
}
