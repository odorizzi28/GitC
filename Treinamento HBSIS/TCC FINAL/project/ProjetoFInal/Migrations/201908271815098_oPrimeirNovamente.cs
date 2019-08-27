namespace ProjetoFInal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oPrimeirNovamente : DbMigration
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
                "dbo.Locacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Veiculo = c.Int(nullable: false),
                        Valor = c.Int(nullable: false),
                        Periodo = c.Int(nullable: false),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        TipoVeiculo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modeloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Marcas = c.Int(nullable: false),
                        TipoVeiculo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PeriodoLocacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade_Vagas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Quantidade_Vaga",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoVeiculo = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TermosDeUsoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoVeiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ValorMensalVeiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoVeiculo = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Veiculoes",
                c => new
                    {
                        Usuario = c.String(nullable: false, maxLength: 128),
                        CodModelo = c.Int(nullable: false),
                        CodCor = c.Int(nullable: false),
                        Placa = c.String(),
                    })
                .PrimaryKey(t => t.Usuario);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Veiculoes");
            DropTable("dbo.ValorMensalVeiculoes");
            DropTable("dbo.TipoVeiculoes");
            DropTable("dbo.TermosDeUsoes");
            DropTable("dbo.Status");
            DropTable("dbo.Quantidade_Vaga");
            DropTable("dbo.PeriodoLocacaos");
            DropTable("dbo.Modeloes");
            DropTable("dbo.Marcas");
            DropTable("dbo.Locacaos");
            DropTable("dbo.Cors");
        }
    }
}
