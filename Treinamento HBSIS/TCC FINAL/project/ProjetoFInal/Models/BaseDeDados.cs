using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoFInal.Models
{
    public class BaseDeDados: DbContext
    {
        public DbSet<TipoVeiculo> TipoVeiculos { get; set; }
        public DbSet<Cor> Cors { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<TermosDeUso> TermosDeUsos { get; set; }
        public DbSet<PeriodoLocacao> PeriodoLocacaos { get; set; }
        public DbSet<Quantidade_Vaga> Quantidade_Vagas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Status> Statos{ get; set; }
        public DbSet<ValorMensalVeiculo> ValorMensals { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
    }
}