using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bankingsystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Bankingsystem.Services
{
    public interface IAccountService
    {
        Task<ApplicationUser> FindUserById();
    }

    public class AccountService : IAccountService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AccountService(UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<ApplicationUser> FindUserById()
        {
            var userid = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
            var user = await _userManager.FindByIdAsync(userid);
            return user;
        }
    }
}
