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
        public int Id { get; set; }
        public int CodUsuario { get; set; }
        public int CodModelo { get; set; }
        public int CodMarca { get; set; }
        public int CodCor { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaPlaca)]
        public string Placa { get; set; }
        
    }
}