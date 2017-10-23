using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab28Erik.Models
{
    public class AdminRegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "You do not meet the password requirements", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [RegularExpression("^?=.*[A-Z]$", ErrorMessage = "You need to have at least one Capital letter")]
        public string Password { get; set; }
    }
}
