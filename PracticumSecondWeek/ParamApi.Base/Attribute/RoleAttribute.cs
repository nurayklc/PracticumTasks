using ParamApi.Base.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamApi.Base.Attribute
{
    public class RoleAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                if (value is null)
                    return ValidationResult.Success;

                if (Enum.IsDefined(typeof(RoleEnum), value))
                    return ValidationResult.Success;
                else
                    return new ValidationResult("Invalid Role field.");
            }
            catch (Exception)
            {
                return new ValidationResult("Invalid Role field.");
            }
        }
    }
}
