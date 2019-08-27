namespace ProjetoFInal.Migrations
{
    using ProjetoFInal.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoFInal.Models.BaseDeDados>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjetoFInal.Models.BaseDeDados context)
        {

            var TipoVeiculos = new List<TipoVeiculo>() {
                new TipoVeiculo(){Id = 0,Descricao = "Automóvel"},
                new TipoVeiculo(){Id = 1,Descricao = "Moto"},
                new TipoVeiculo(){Id = 2,Descricao = "Bicicleta"},
                new TipoVeiculo(){Id = 3,Descricao = "Patinete"},
                };

            TipoVeiculos.ForEach(s => context.TipoVeiculos.AddOrUpdate(p => p.Descricao, s));
            context.SaveChanges();

            var incrementMarcasCodigo = 1;

            var Marcas = new List<Marca>()
            {
                 new Marca(){TipoVeiculo = 1, Descricao = "Audi", Id = incrementMarcasCodigo++},
                 new Marca(){TipoVeiculo = 1, Descricao = "BMW", Id = incrementMarcasCodigo++}
            };
            Marcas.ForEach(s => context.Marcas.AddOrUpdate(p => p.Id, s));
            context.SaveChanges();


            var Modelos = new List<Modelo>()
            {
                new Modelo(){ Marcas=1,TipoVeiculo=1,Descricao="100" },
                new Modelo(){ Marcas=1,TipoVeiculo=1,Descricao="100 Avant" },
            };
        }

    }
}
