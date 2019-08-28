using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFInal.Models
{
    public class Locacao : UserControls
    {
        public int Id { get; set; }
        public int Veiculo { get; set; }
        public int Valor { get; set; }
        public int Periodo { get; set; }
        public string Descricao { get; set; }

    }
}