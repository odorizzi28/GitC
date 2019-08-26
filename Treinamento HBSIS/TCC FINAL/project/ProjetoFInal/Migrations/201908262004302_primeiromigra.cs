namespace ProjetoFInal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primeiromigra : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        IdMarca = c.Int(nullable: false, identity: true),
                        NomeMarca = c.String(),
                    })
                .PrimaryKey(t => t.IdMarca);
            
            CreateTable(
                "dbo.Modeloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        IdMarca = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.IdMarca, cascadeDelete: true)
                .Index(t => t.IdMarca);
            
            CreateTable(
                "dbo.Veiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Modeloes", "IdMarca", "dbo.Marcas");
            DropIndex("dbo.Modeloes", new[] { "IdMarca" });
            DropTable("dbo.Veiculoes");
            DropTable("dbo.Modeloes");
            DropTable("dbo.Marcas");
            DropTable("dbo.Cors");
        }
    }
}
