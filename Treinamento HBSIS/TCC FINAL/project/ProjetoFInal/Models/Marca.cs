using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFInal.Models
{
    public class Marca : UserControls
    {
        [Key]
        public int IdMarca { get; set; }
        public string NomeMarca { get; set; }

       
    }
}