namespace DigitalLetters_MaryLouiseAnhanceAbrena.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class receivers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recievers",
                c => new
                    {
                        MessageReceiveId = c.Int(nullable: false, identity: true),
                        ReceiverContact = c.String(),
                        ReceivedMessage = c.String(),
                    })
                .PrimaryKey(t => t.MessageReceiveId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Recievers");
        }
    }
}
