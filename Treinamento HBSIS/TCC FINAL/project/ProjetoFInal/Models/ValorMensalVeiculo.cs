using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFInal.Models
{
    public class ValorMensalVeiculo : UserControls
    {
        public int Id { get; set; }
        public int TipoVeiculo { get; set; }
        public Decimal Valor { get; set; }
    }
}