using System.Data.Entity.Migrations;

namespace LifeStruct.Migrations
{
    public partial class Activity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActivityModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Multiplier = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ActivityModels");
        }
    }
}
