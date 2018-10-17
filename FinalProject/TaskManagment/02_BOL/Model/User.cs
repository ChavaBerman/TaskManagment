using _02_BOL.validations;
using System.ComponentModel.DataAnnotations;

namespace _02_BOL
{
    public class User
    {
        [Key]
        [Required]
        public int IdUser { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "user name can contains maximum 15 chars."), MinLength(3, ErrorMessage = "user name must contains minimum 3 chars.")]
        public string UserName { get; set; }

        [Required]
        [MaxLength(6, ErrorMessage = "password must contains 6 chars."), MinLength(6, ErrorMessage = "password must contains 6 chars.")]
        [UniquePassword]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public int IdStatus { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
