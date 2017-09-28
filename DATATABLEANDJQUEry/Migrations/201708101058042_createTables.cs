namespace DATATABLEANDJQUEry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students3",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FathersName = c.String(),
                        Standard = c.String(),
                        Section = c.String(),
                        Age = c.Int(nullable: false),
                        HomeAddress = c.String(),
                        PermanentAddress = c.String(),
                        Contact = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students3");
        }
    }
}
