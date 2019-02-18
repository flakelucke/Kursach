using Microsoft.AspNetCore.Identity;

namespace Kursach.Models.UsersModels
{
    public class AppUser: IdentityUser
    {
       public string FirstName { get; set; }
       public string LastName { get; set; } 
    }
}