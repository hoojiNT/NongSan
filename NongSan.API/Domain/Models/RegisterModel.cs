using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongSan.API.Domain.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Username không được để trống!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email không được để trống!")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password không được để trống!")]
        public string Password { get; set; }

    }
}
