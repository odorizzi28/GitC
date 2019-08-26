using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoFInal.Models
{
    public class BaseDeDados: DbContext
    {
        public DbSet<Veiculo>veiculos { get; set; }

        public DbSet<Cor> Cors { get; set; }

        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<TermosDeUso> TermosDeUsos { get; set; }
    }
}