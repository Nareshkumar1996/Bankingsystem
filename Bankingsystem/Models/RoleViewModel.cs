using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bankingsystem.Models
{
    
    public class RoleViewModel
    {
        public string RoleName { get; set; }
        public string Uname { get; set; }
        public string Rname { get; set; }
        public static IEnumerable<IdentityRole> identityRoles { get; set; }
        public static IEnumerable<ApplicationUser> applicationUsers { get; set; }

    public class AddRemoveUsers
        { 
        public IEnumerable<ApplicationUser> memberofrole { get; set; }
        public IEnumerable<ApplicationUser> nonmemberofrole { get; set; }
        public IdentityRole identityRole { get; set; }
        }
    public static IEnumerable<SelectListItem> GetUserlist()
        {
            List<SelectListItem> Roless = new List<SelectListItem>();
            foreach (var items in applicationUsers)
            {
                Roless.Add(new SelectListItem
                {
                    Value = items.Email,
                    Text = items.Email
                }
                );
            }
            return Roless;
        }

        public static IEnumerable<SelectListItem> GetRolelist()
        {
            List<SelectListItem> Roless = new List<SelectListItem>();
            foreach (var items in identityRoles)
            {
                Roless.Add(new SelectListItem
                {
                    Value = items.Name,
                    Text = items.Name
                }
                );
            }
            return Roless;
        }
    }
}
