using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models.ViewModels
{
    public class RegisterModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password is not equal!!")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public static implicit operator AppUser(RegisterModel registerModel)
        {
            return new AppUser
            {
                Email = registerModel.Email,
                UserName = registerModel.UserName,

            };
        }
    }
}
