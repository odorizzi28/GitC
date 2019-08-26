using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFInal.Models
{
    public class Modelo : UserControls
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        [ForeignKey("IdMarca")]
        public Marca Marca { get; set; }
        public int IdMarca { get; set; }


    }
}