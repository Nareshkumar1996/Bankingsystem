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
        Transaction MapTransaction(string userId, string narration, int withdrawAmount, int depositAmount, int closingBalance);
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

        public Transaction MapTransaction(string userId, string narration, int withdrawAmount, int depositAmount, int closingBalance)
        {
            var transaction = new Transaction
            {
                Userid = userId,
                Datetime = DateTime.Now,
                Narration = narration,
                Withdrawl = String.IsNullOrEmpty(withdrawAmount.ToString()) ? 0 : withdrawAmount,
                Deposit = String.IsNullOrEmpty(depositAmount.ToString()) ? 0 : depositAmount,
                ClosingBalance = closingBalance
            };
            return transaction;
        }
    }
}
