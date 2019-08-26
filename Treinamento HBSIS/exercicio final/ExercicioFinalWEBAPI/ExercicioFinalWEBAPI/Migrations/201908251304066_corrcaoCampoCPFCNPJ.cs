namespace ExercicioFinalWEBAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class corrcaoCampoCPFCNPJ : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "CPfouCNPJ", c => c.String());
            DropColumn("dbo.Clientes", "CPf");
            DropColumn("dbo.Clientes", "Cnpj");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "Cnpj", c => c.String());
            AddColumn("dbo.Clientes", "CPf", c => c.String());
            DropColumn("dbo.Clientes", "CPfouCNPJ");
        }
    }
}
