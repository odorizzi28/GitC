namespace ExercicioFinalWEBAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeCompleto = c.String(),
                        EstadoCivil = c.Int(nullable: false),
                        Rg = c.Int(nullable: false),
                        CPf = c.Int(nullable: false),
                        Cnpj = c.Int(nullable: false),
                        NomeFantasia = c.Int(nullable: false),
                        Cep = c.Int(nullable: false),
                        Endereço = c.Int(nullable: false),
                        Cidade = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        Telefone = c.Int(nullable: false),
                        Celular = c.Int(nullable: false),
                        Email = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
