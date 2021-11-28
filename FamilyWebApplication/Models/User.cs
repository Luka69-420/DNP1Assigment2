using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}