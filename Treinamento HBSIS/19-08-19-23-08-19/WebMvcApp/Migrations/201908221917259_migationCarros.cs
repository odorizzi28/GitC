namespace WebMvcApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migationCarros : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Placa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carros");
        }
    }
}
