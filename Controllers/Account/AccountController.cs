using Kursach.Models;
using Kursach.Models.UsersModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Controllers.Account
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
         private readonly DataContext _appDbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
    }
}