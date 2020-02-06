using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bankingsystem.Data;
using Bankingsystem.Models;
using Bankingsystem.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bankingsystem.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        public AccountController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager)
        {
            _appDbContext = applicationDbContext;
            _userManager = userManager;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var userid = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userid).Result;

            return View(user);
        }
        public IActionResult GetBalance()
        {
            var userid = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userid).Result;

            return View(user);
        }
        public ViewResult Depositform()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Deposit(AccountViewModel accountViewModel)
        {
            var wa = accountViewModel.DepositAmount;
            var userid = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userid).Result;
            user.BalanceAmount = user.BalanceAmount + wa;
            _appDbContext.Update(user);
            _appDbContext.SaveChanges();
            return View(accountViewModel);
        }
        public ViewResult Withdrawform()
        {
            return View();
        }
        public IActionResult Withdraw(AccountViewModel accountViewModel)
        {
            var wa = accountViewModel.WithdrawAmount;
            var userid = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userid).Result;
            user.BalanceAmount = user.BalanceAmount - wa;
            _appDbContext.Update(user);
            _appDbContext.SaveChanges();
            return View(accountViewModel);

        }
        public ViewResult Details()
        {
            var userid = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userid).Result;
            return View(user);
        }
    }
}
