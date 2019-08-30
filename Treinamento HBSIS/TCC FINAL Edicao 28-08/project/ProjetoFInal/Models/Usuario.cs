using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFInal.Models
{
    public class Usuario : UserControls
    {
        [Key]
        public int Id { get; set; }
        public String Nome { get; set; }
        [CustomValidFields(Enums.ValidFields.ValidaEmail)]
        public string Email { get; set; }
        public bool PDC { get; set; }
        public bool TrabalhoNoturno { get; set; }
        public bool ResideForaBNU { get; set; }
        public bool OfereceCarona { get; set; }
        public bool UsuarioGestor { get; set; }
        public int CodVeiculo { get; set; }

    }
}