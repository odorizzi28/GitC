using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExercicioFinalWEBAPI.Models
{
    public class Cliente : UserControls
    {
        [Key]
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        [CustomValidFields(Enums.ValidaFields.ValidaEstadoCivil)]
        public string EstadoCivil { get; set; }
        public string Rg { get; set; }
        [CustomValidFields(Enums.ValidaFields.ValidaCPFouCNPJ)]
        public string CPfouCNPJ { get; set; }
        public string NomeFantasia { get; set; }
        [CustomValidFields(Enums.ValidaFields.ValidaCEP)]
        public string Cep  { get; set; }
        public string Endereço { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        [CustomValidFields(Enums.ValidaFields.ValidaTelefone)]
        public string Telefone { get; set; }
        [CustomValidFields(Enums.ValidaFields.ValidaCelular)]
        public string Celular { get; set; }
       [CustomValidFields(Enums.ValidaFields.ValidaEmail)]
        public string Email { get; set; }
                   

        
        
    }
}