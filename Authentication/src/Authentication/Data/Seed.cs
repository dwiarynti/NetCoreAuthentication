using Authentication.Models;
using Authentication.Models.AccountViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Data
{
    public class Seed
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public Seed(
           UserManager<ApplicationUser> userManager
         )
        {
            _userManager = userManager;
        }
        
        public void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if(context.Users.Any())
            {
                return;
            }
            var users = new ApplicationUser();
            users.UserName = "Admin";
            users.Email = "";
            
        }
    }
}
