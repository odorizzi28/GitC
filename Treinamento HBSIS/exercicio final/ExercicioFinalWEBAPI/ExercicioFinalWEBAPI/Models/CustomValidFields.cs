using ExercicioFinalWEBAPI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ExercicioFinalWEBAPI.Models
{
    public class CustomValidFields:ValidationAttribute
    {
        ContextDB db = new ContextDB();
      
        private ValidaFields typeField;
        public CustomValidFields(ValidaFields type)
        {
            typeField = type;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (value != null)
            {

                switch (typeField)
                {
                    case ValidaFields.ValidaEstadoCivil:
                        {
                            Cliente client = db.clientes.FirstOrDefault(x => x.EstadoCivil == value.ToString());

                            if (value.ToString() == "Solteiro" || value.ToString() == "Casado" || value.ToString() == "Divorciado" || value.ToString() == "Viúvo")
                            {
                                return ValidationResult.Success;
                            }

                            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório EX: Solteiro Casado Viúvo Divorciado.");
                        }
                    case ValidaFields.ValidaCPFouCNPJ:{ return ValidarCPFouCNPJ(value); } 
                    case ValidaFields.ValidaEmail:    { return ValidarEmail(value,validationContext.DisplayName); } 
                    case ValidaFields.ValidaCelular:  { return ValidarCelular(value, validationContext.DisplayName); } 
                    case ValidaFields.ValidaTelefone: { return ValidarFone(value, validationContext.DisplayName); } 
                    case ValidaFields.ValidaRG:       { return ValidarRG(value, validationContext.DisplayName); }
                    case ValidaFields.ValidaCEP:      { return ValidarCEP(value, validationContext.DisplayName); } 
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


        private ValidationResult ValidarCPFouCNPJ(object value)
        {
            Cliente cliente = db.clientes.FirstOrDefault(x => x.CPfouCNPJ == value.ToString());

            if (cliente == null)
            {
                bool resultCPF = Regex.IsMatch(value.ToString(), @"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})");
                if (resultCPF)
                {
                    return ValidationResult.Success;
                }
                return new ValidationResult($"O campo é inválido.");
            }
            return new ValidationResult("CPF ou CNPJ já cadastrado em nossa base de dados!");



        }
        //
        private ValidationResult ValidarCelular(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^(\(11\)[9][0-9]{4}-[0-9]{4})|(\(1[2-9]\) [5-9][0-9]{3}-[0-9]{4})|(\([2-9][1-9]\) [5-9][0-9]{3}-[0-9]{4})$");
            if (result)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult($"O campo {displayField} é inválido.EX(XX) XXXXX-XXXX");

        }



        private ValidationResult ValidarFone(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^\(\d{2}\)\d{4}-\d{4}$");
            if (result)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult($"O campo {displayField} é inválido.EX(XX)XXXX-XXXX ");

        }

        private ValidationResult ValidarCEP(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^\d{5}-\d{3}$");
            if (result)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult($"O campo {displayField} é inválido. EX XXXXX-XXX");

        }

        private ValidationResult ValidarRG(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^(\d{9})|(\d{2}\.\d{3}\.\d{3}-\d)$");
            if (result)
                return ValidationResult.Success;
            return new ValidationResult($"o campo {displayField} deve ser no formato XX.XXX.XXX-X");
        }

    }
}