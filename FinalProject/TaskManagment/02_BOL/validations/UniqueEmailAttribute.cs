using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_BOL.validations
{
    public class UniqueEmailAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult validationResult = ValidationResult.Success;
            try
            {
                List<User> users = GetDataByReflection.GetUsers();
                int userId = (validationContext.ObjectInstance as User).IdUser;
                string email = value.ToString();

                //check if email of the user parameter is unique
                bool isUnique = users.Any(user => user.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && user.IdUser != userId) == false;
                if (isUnique == false)
                {
                    ErrorMessage = "Email already exists. Choose another email address.";
                    validationResult = new ValidationResult(ErrorMessageString);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return validationResult;
        }
      
    }
}
