namespace DigitalLetters_MaryLouiseAnhanceAbrena.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class senders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Senders",
                c => new
                    {
                        MessageSentId = c.Int(nullable: false, identity: true),
                        SenderContacts = c.String(),
                        SenderMessage = c.String(),
                    })
                .PrimaryKey(t => t.MessageSentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Senders");
        }
    }
}
