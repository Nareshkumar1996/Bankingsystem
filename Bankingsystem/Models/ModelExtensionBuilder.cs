using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bankingsystem.Models
{
    public static class ModelExtensionBuilder
    {
        public static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            if(userManager.FindByEmailAsync("admin@gmail.com").Result == null)
            {
                ApplicationUser user = new ApplicationUser
                {
                    UserName = "Admin",
                    Email = "admin@gmail.com"
                };
                IdentityResult result =  userManager.CreateAsync(user, "Password@1").Result;


                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            } 
        }
    }
}
