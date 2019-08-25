namespace ExercicioFinalWEBAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecaoCampos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "EstadoCivil", c => c.String());
            AlterColumn("dbo.Clientes", "Rg", c => c.String());
            AlterColumn("dbo.Clientes", "CPf", c => c.String());
            AlterColumn("dbo.Clientes", "Cnpj", c => c.String());
            AlterColumn("dbo.Clientes", "NomeFantasia", c => c.String());
            AlterColumn("dbo.Clientes", "Cep", c => c.String());
            AlterColumn("dbo.Clientes", "Endereço", c => c.String());
            AlterColumn("dbo.Clientes", "Cidade", c => c.String());
            AlterColumn("dbo.Clientes", "Estado", c => c.String());
            AlterColumn("dbo.Clientes", "Telefone", c => c.String());
            AlterColumn("dbo.Clientes", "Celular", c => c.String());
            AlterColumn("dbo.Clientes", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Email", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "Celular", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "Telefone", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "Estado", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "Cidade", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "Endereço", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "Cep", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "NomeFantasia", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "Cnpj", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "CPf", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "Rg", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "EstadoCivil", c => c.Int(nullable: false));
        }
    }
}
