using ProjetoFInal.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ProjetoFInal.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        BaseDeDados db = new BaseDeDados();

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
                    // case ValidFields.ValidaUsuario: { return ValidarLogin(value); }
                    case ValidFields.ValidaEmail: { return ValidarEmail(value, validationContext.DisplayName); }
                     case ValidFields.ValidaPlaca: { return ValidaPlacar(value); }
                    // case ValidFields.ValidaNome: { return ValidarNome(value); }
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
                if (value != null)
                {
                    Usuario user = db.Usuarios.FirstOrDefault(x => x.Email == value.ToString());

                    if (user == null)
                    {
                        return ValidationResult.Success;
                    }
                    else
                    {
                        return new ValidationResult("E-mail já cadastrado.");
                    }
                }

                return ValidationResult.Success;

            }
            return new ValidationResult($"O campo {displayField} é inválido.");

        }


        private ValidationResult ValidaPlacar(object value)
        {
            bool placaCarroBrasil = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[-][0-9]{4}$");

            bool placaCarroMercoSul = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}$");

            bool placaMotoMercoSul = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}[0-9]{2}[a-zA-Z]{1}[0-9]{1}$");
            
            if (placaCarroBrasil)
            {
                return ValidationResult.Success;
            }
            
            if (placaCarroMercoSul)
            {
                return ValidationResult.Success;
            }
            if (placaMotoMercoSul)
            {              
                return ValidationResult.Success;
            }
            
            return new ValidationResult("A placa informada não está no formato aceitável");
        }
        private ValidationResult ValidaPlacaDuplicada(object value)
        {
            Locacao CodPlaca = db.Locacoes.FirstOrDefault(x => x.PlacaVeiculo == value.ToString());

            if (CodPlaca != value)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("A placa informada já está cadastrada no sistema");


        }
    }
}