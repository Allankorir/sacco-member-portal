using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SaccoDashboard.Models.Auth
{
    public class LoginVm
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";

        [Required]
        public string Password { get; set; } = "";
    }
}
