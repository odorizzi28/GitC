using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFInal.Models
{
    public class Marca 
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int TipoVeiculo { get; set; }
        

       
    }
}