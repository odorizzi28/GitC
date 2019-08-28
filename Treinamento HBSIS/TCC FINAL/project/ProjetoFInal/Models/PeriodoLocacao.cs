using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFInal.Models
{
    public class PeriodoLocacao : UserControls
    {

        public int Id { get; set; }
        public int TipoVeiculo { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

    }
}