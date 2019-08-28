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
                new Marca(){TipoVeiculo = 1, Id =  incrementMarcasCodigo++,Descricao = "Audi"},
                new Marca(){TipoVeiculo = 1, Id  = incrementMarcasCodigo++,Descricao = "BMW"},
                new Marca(){TipoVeiculo = 1, Id  = incrementMarcasCodigo++,Descricao = "Chevrolet"},
                new Marca(){TipoVeiculo = 1, Id  = incrementMarcasCodigo++,Descricao = "Citröen"},
                new Marca(){TipoVeiculo = 1, Id  = incrementMarcasCodigo++,Descricao = "Fiat"},
                new Marca(){TipoVeiculo = 1, Id  = incrementMarcasCodigo++,Descricao = "Ford"},
                new Marca(){TipoVeiculo = 1, Id  = incrementMarcasCodigo++,Descricao = "Honda"},
                new Marca(){TipoVeiculo = 1, Id  = incrementMarcasCodigo++,Descricao = "Hyundai"},
                new Marca(){TipoVeiculo = 1, Id  = incrementMarcasCodigo++,Descricao = "Jeep"},
                new Marca(){TipoVeiculo = 1, Id  = incrementMarcasCodigo++,Descricao = "Kia"},
                new Marca(){TipoVeiculo = 1, Id  = incrementMarcasCodigo++,Descricao = "Mitsubishi"},
                new Marca(){TipoVeiculo = 1, Id  = incrementMarcasCodigo++,Descricao = "Nissan"},
                new Marca(){TipoVeiculo = 1, Id  = incrementMarcasCodigo++,Descricao = "Peugeot"},
                new Marca(){TipoVeiculo = 1, Id  = incrementMarcasCodigo++,Descricao = "Renault"},
                new Marca(){TipoVeiculo = 1, Id  = incrementMarcasCodigo++,Descricao = "Toyota"},
                new Marca(){TipoVeiculo = 1, Id  = incrementMarcasCodigo++,Descricao = "Volkswagen"},

                new Marca(){TipoVeiculo = 3, Id  = incrementMarcasCodigo++,Descricao = "Dafra"},
                new Marca(){TipoVeiculo = 3, Id  = incrementMarcasCodigo++,Descricao = "Honda"},
                new Marca(){TipoVeiculo = 3, Id  = incrementMarcasCodigo++,Descricao = "Suzuki"},
                new Marca(){TipoVeiculo = 3, Id  = incrementMarcasCodigo++,Descricao = "Yamaha"},
                new Marca(){TipoVeiculo = 3, Id  = incrementMarcasCodigo++,Descricao = "Kawasaki"},
                new Marca(){TipoVeiculo = 3, Id  = incrementMarcasCodigo++,Descricao = "BMW"},
                new Marca(){TipoVeiculo = 3, Id  = incrementMarcasCodigo++,Descricao = "Ducati"},
            };

            Marcas.ForEach(s => context.Marcas.AddOrUpdate(p => p.Id, s));
            context.SaveChanges();


            var Modelos = new List<Modelo>()
            {
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "100" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "100 Avant" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "80" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "80 Avant" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "80 Cabriolet" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "A1" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "A3" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "A3 Cabriolet" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "A3 Sedan" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "A4" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "A4 Avant" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "A4 Cabriolet" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "A5" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "A6" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "A6 Avant" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "A7" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "A8" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "Allroad Avant" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "Q3" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "Q5" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "Q7" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "R8" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "RS2 Avant" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "RS3" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "RS3 Sedan" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "RS4" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "RS4 Avant" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "RS5" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "RS6" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "RS6 Avant" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "RS7" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "RS Q3" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "S3" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "S3 Sedan" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "S4" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "S4 Avant" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "S5" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "S6" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "S6 Avant" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "S7" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "S8" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "SQ5" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "TT" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "TT RS" },
                new Modelo(){Marcas = 1, TipoVeiculo = 1, Descricao = "TTS" },


                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "1M"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "2800"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "I3"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "I8"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "M2"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "M3"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "M3 Cabrio"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "M3 Sedan"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "M4"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "M5"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "M5 Touring"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "M6"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 1"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 1 Cabrio"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 1 Coupé"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 2"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 3"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 3 Cabrio"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 3 Compact"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 3 Coupé"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 3 Touring"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 4"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 5"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 5 Touring"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 6 Cabrio"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 6 Coupé"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 6 Gran Coupé"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 7"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Série 8"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "X1"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "X2"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "X3"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "X4"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "X5"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "X6"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Z3"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Z4 Coupé"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Z4 Roadster"},
                new Modelo(){ Marcas = 2, TipoVeiculo = 1, Descricao = "Z8"},




                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "A10"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "A20"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Agile"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Astra Hatch"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Astra Sedan"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Astra Wagon"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Astrovan"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Bel Air"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Blazer"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Bonanza"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Brasil"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Brasinca"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "C10"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "C14"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "C20"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Calibra Coupe"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Camaro"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Caprice Sedan"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Caprice Wagon"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Captiva"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Caravan"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Cavalier"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Celta"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Chevette Hatch"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Chevette Sedan"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Chevy 500"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Cheyenne"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Classic"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Cobalt"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Colorado"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Corsa Hatch"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Corsa Pick-Up"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Corsa Sedan"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Corsa Wagon"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Corsica Sedan"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Corvette"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Cruze"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Cruze Sport6"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "D10"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "D20"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Equinox"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "HHR"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Impala"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Ipanema"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Kadett"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Kadett Conversivel"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Lumina APV"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Lumina Sedan"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Malibu"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Marajo"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Meriva"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Montana"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Montana Combo"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Monza"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Monza Hatch"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Omega"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Onix"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Opala"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Opala Coupe"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Pick Up Chevrolet"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Prisma"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "S10 Cabine Dupla"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "S10 Cabine Simples"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Silverado"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Sonic"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Sonic Sedan"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Space Van"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Spin"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "SS10"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "SSR"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Suburban"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Suprema"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Tigra"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Tracker"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Trafic"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "TrailBlazer"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Vectra"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Vectra GT"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Veraneio"},
                new Modelo(){ Marcas = 3, TipoVeiculo = 1,Descricao = "Zafira"};

            Modelos.ForEach(s => context.Marcas.AddOrUpdate(p => p.Id, s));
            context.SaveChanges();

        }




    }
    }
}

