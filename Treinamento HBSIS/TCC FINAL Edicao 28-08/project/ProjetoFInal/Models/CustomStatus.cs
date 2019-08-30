using ProjetoFInal.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFInal.Models
{
    public class CustomStatus : ValidationAttribute
    {
        BaseDeDados db = new BaseDeDados();

        private readonly ValidFields typeField;
        public CustomStatus(ValidFields type)
        {
            typeField = type;
        }


        protected override ValidationResult IsValid(object value, CustomStatus validationContext)
        {

            if (value != null)
            {
                switch (typeField)
                {
                     case Status.VIGENTE: { return (value); }
                    default: { } break;
                }
            }
            return new ValidationResult($"O campo: {validationContext.DisplayName} é obrigatorio.");
        }

    }
}
