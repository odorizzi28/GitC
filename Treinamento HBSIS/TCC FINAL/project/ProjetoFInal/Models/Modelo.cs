using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFInal.Models
{
    public class Modelo 
    {
        
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Marcas { get; set; }
        public int TipoVeiculo { get; set; }

     
    }
}