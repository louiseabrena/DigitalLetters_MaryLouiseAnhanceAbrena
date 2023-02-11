namespace DigitalLetters_MaryLouiseAnhanceAbrena.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class letters : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DigitalLetters",
                c => new
                    {
                        LetterId = c.Int(nullable: false, identity: true),
                        SenderName = c.String(),
                        LetterMessage = c.String(),
                        RecieverName = c.String(),
                    })
                .PrimaryKey(t => t.LetterId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DigitalLetters");
        }
    }
}
