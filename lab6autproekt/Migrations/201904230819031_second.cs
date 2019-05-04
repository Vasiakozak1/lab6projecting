namespace lab6autproekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FirstPartParameters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LengthOfMainPart = c.Double(nullable: false),
                        WidthOfMainPart = c.Double(nullable: false),
                        HeightOfMainPart = c.Double(nullable: false),
                        HeightOfFirst = c.Double(nullable: false),
                        LengthOfFirst = c.Double(nullable: false),
                        LengthOfExtrusion = c.Double(nullable: false),
                        WidthOfExtrusion = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SecondPartParameters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LengthOfMainPart = c.Double(nullable: false),
                        WidthOfMainPart = c.Double(nullable: false),
                        LenthOfTop = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ThirdPartParameters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LengthOfFoundation = c.Double(nullable: false),
                        WidthOfFoundation = c.Double(nullable: false),
                        HeightOfFoundation = c.Double(nullable: false),
                        HeightOfMainPart = c.Double(nullable: false),
                        WidthOfCut = c.Double(nullable: false),
                        HeightOfCut = c.Double(nullable: false),
                        RadiuesOfInnerCircle = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.TestEntities");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TestEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.ThirdPartParameters");
            DropTable("dbo.SecondPartParameters");
            DropTable("dbo.FirstPartParameters");
        }
    }
}
