 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFInal.Models
{
    public class Locacao : UserControls
    {
        public int Id { get; set; }
        public int TipoVeiculo { get; set; }
        public int CodModelo { get; set; }
        public int CodMarca { get; set; }
        public int CodCor { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaPlaca)]
        public string PlacaVeiculo { get; set; }
        public int CodPeriodo { get; set; }
        public string Descricao { get; set; }
        public int CodUsuario { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaAceitoTermosDeUso)]
        public bool AceitoTermoDeUso { get; set; }



    }
}