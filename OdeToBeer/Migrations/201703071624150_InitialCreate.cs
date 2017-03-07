namespace OdeToBeer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Image = c.String(),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BeerReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rating = c.String(),
                        Comments = c.String(),
                        BeerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Beers", t => t.BeerId, cascadeDelete: true)
                .Index(t => t.BeerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BeerReviews", "BeerId", "dbo.Beers");
            DropIndex("dbo.BeerReviews", new[] { "BeerId" });
            DropTable("dbo.BeerReviews");
            DropTable("dbo.Beers");
        }
    }
}
