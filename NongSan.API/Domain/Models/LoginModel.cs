using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongSan.API.Domain.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username không được để trống!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password không được để trống!")]
        public string Password { get; set; }
    }
}
