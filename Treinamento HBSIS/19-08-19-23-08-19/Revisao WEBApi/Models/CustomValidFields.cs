using Revisao_WEBApi.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Revisao_WEBApi.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        ContextDB db = new ContextDB();

        private ValidFields typeField;
        public CustomValidFields(ValidFields type)
        {
            typeField = type;
        }


        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (value != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaLogin: { return ValidarLogin(value);}
                    case ValidFields.ValidaEmail: { return ValidarEmail(value, validationContext.DisplayName); }
                    case ValidFields.ValidaSenha: { return ValidarSenha(value);}
                    case ValidFields.ValidaNome: {  return ValidarNome(value);}
                    default: { } break;
                }
            }
            return new ValidationResult($"O campo: {validationContext.DisplayName} é obrigatorio.");
        }

        private ValidationResult ValidarEmail(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (result)
            {

                return ValidationResult.Success;
            }
            return new ValidationResult($"O campo {displayField} é inválido.");

        }




        private ValidationResult ValidarNome(object value)
        {
            if (value != null)
            {
                if (value.ToString().Length>2)
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Nome Inválido, o nome deve conter pelo menos 3 letras.");
        }

        private ValidationResult ValidarLogin(object value)

        {
            Usuario user = db.usuarios.FirstOrDefault(x => x.Login == value.ToString());

            if (user == null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Login já cadastrado em nossa base de dados.");
        }


        private ValidationResult ValidarSenha(object value)
        {
            if (value != null)
            {
                if (value.ToString().Length > 6 && value.ToString().Length < 20 && VerificaNumero(value.ToString()))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Senha deve conter letras e números.");
        }




        private bool VerificaNumero(string senha)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (senha.Contains(i.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

    }
}