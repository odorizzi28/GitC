using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Revisao_WEBApi.Models
{
    public class Usuario : UserControls
    {
        [Key]
        public int Id { get; set; }

        [CustomValidFields(enums.ValidFields.ValidaNome)]
        public string Nome { get; set; }

        [CustomValidFields(enums.ValidFields.ValidaEmail)]
        public string Email { get; set; }
        [CustomValidFields(enums.ValidFields.ValidaLogin)]

        public string Login { get; set; }
        [CustomValidFields(enums.ValidFields.ValidaSenha)]

        public string Senha { get; set; }


    }
}