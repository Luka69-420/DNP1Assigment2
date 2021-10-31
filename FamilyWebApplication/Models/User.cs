using Microsoft.AspNetCore.Mvc;

namespace Models
{
    public class User
    {
        [FromQuery]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}