using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bankingsystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static Bankingsystem.Models.RoleViewModel;

namespace Bankingsystem.Controllers
{
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public RolesController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Listroles()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel roleViewModel)
        {
            IdentityRole identityRole = new IdentityRole();
            identityRole.Name = roleViewModel.RoleName;
            IdentityResult result = await _roleManager.CreateAsync(identityRole);
            if(result.Succeeded)
            {
                return RedirectToAction("Listroles");
            }
            return View(roleViewModel);
        }
        public async Task<IActionResult> Delete(string id)
        {
          IdentityRole role = await _roleManager.FindByIdAsync(id);
          IdentityResult result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Listroles");
            }
            return View(id);
        }
        public IActionResult AssignRoles()
        {
            RoleViewModel roleViewModel = new RoleViewModel();
            
            RoleViewModel.applicationUsers = _userManager.Users.ToList();
            RoleViewModel.identityRoles = _roleManager.Roles.ToList();
            return View(roleViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> AssignRoles(RoleViewModel roleViewModel)
        {
            var selectedUser = roleViewModel.Uname;
            var selectedRole = roleViewModel.Rname;
         ApplicationUser user = await _userManager.FindByEmailAsync(selectedUser);
           await _userManager.AddToRoleAsync(user, selectedRole);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> AddRemoveUsers(string id)
        {
            var selectedRole = await _roleManager.FindByIdAsync(id);
            List<ApplicationUser> users = _userManager.Users.ToList();
            List<ApplicationUser> members = new List<ApplicationUser>();
            List<ApplicationUser> nonmembers = new List<ApplicationUser>();
            foreach (var user in users)
            {
             var check  = await _userManager.IsInRoleAsync(user, selectedRole.Name) ;
                if(check == true) {
                    members.Add(user);
                }else {
                    nonmembers.Add(user);
                }
            }
            AddRemoveUsers addRemoveUsers = new AddRemoveUsers();
            addRemoveUsers.memberofrole = members;
            addRemoveUsers.nonmemberofrole = nonmembers;
            addRemoveUsers.identityRole = selectedRole;
            return View(addRemoveUsers);
        }
        
        public async Task<IActionResult> Remove(string id, string roleid)
        {
         var user = await _userManager.FindByIdAsync(id);
         var role = await _roleManager.FindByIdAsync(roleid);
         IdentityResult result = await _userManager.RemoveFromRoleAsync(user, role.Name);
            if(result.Succeeded)
            {
                return RedirectToAction("AddRemoveUsers",role);
            }

            return RedirectToAction("AddRemoveUsers", role);
        }
       
        public async Task<IActionResult> Add(string id, string roleid)
        {
            var user = await _userManager.FindByIdAsync(id);
            var role = await _roleManager.FindByIdAsync(roleid);
            IdentityResult result = await _userManager.AddToRoleAsync(user, role.Name);
            if (result.Succeeded)
            {
                return RedirectToAction("AddRemoveUsers",role);
            }
            return RedirectToAction("AddRemoveUsers",role);
        }
    }
}