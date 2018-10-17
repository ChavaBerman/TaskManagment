using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BOL.validations
{
    class UniquePasswordAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult validationResult = ValidationResult.Success;
            try
            {
                List<User> users = GetDataByReflection.GetUsers();
                int userId = (validationContext.ObjectInstance as User).IdUser;
                string password = value.ToString();

                //check if email of the user parameter is unique
                bool isUnique = users.Any(user => user.Password.Equals(password) && user.IdUser != userId) == false;
                if (isUnique == false)
                {
                    ErrorMessage = "Password already exists. Choose another password.";
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
