namespace WebMvcApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class terceiro_migration_Carros : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carros", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Carros", "UsuarioCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.Carros", "UsuarioAlteracao", c => c.Int(nullable: false));
            AddColumn("dbo.Carros", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Carros", "DataAlteracao", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Carros", "DataAlteracao");
            DropColumn("dbo.Carros", "DataCriacao");
            DropColumn("dbo.Carros", "UsuarioAlteracao");
            DropColumn("dbo.Carros", "UsuarioCriacao");
            DropColumn("dbo.Carros", "Ativo");
        }
    }
}
