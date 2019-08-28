using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFInal.Models
{
    
    public class Veiculo : UserControls
    {
        [Key]
        public string Usuario { get; set; }
        public int CodModelo { get; set; }
        public int CodCor { get; set; }
        public string Placa { get; set; }
        
    }
}