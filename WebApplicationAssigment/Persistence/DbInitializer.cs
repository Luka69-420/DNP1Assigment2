using System.Linq;
using Models;

namespace WebApplicationAssigment.Persistence
{
    public static class DbInitializer
    {
        
        public static void Initialize(FamilyDbContext context)
        {
            if (context.Adults.Any())
            {
                return;
            }

            var user = new User()
            {
                Username = "username",
                Password = "password"
            };
            context.Users.Add(user);
        }
    }
}