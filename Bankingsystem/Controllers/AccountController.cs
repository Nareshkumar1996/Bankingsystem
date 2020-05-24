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
            var dp = accountViewModel.DepositAmount;
            var userid = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userid).Result;
            user.BalanceAmount = user.BalanceAmount + dp;
            Transaction transac = new Transaction();
            transac.Datetime = DateTime.Now;
            transac.Userid = user.Id;
            transac.Narration = "You have deposited";
            transac.Deposit = accountViewModel.DepositAmount;
            transac.ClosingBalance = user.BalanceAmount;
            _appDbContext.Update(user);
            _appDbContext.Update(transac);
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

            Transaction transac = new Transaction();
            transac.Datetime = DateTime.Now;
            transac.Userid = user.Id;
            transac.Narration = "You have withdrawn";
            transac.Withdrawl = wa;
            transac.ClosingBalance = user.BalanceAmount;

            _appDbContext.Update(user);
            _appDbContext.Update(transac);
            _appDbContext.SaveChanges();
            return View(accountViewModel);

        }
        public ViewResult Details()
        {
            var userid = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userid).Result;
            return View(user);
        }
        public ViewResult MoneyTransfer()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MoneyTransfer(AccountViewModel accountViewModel)
        {
            //Get logged in user details
            var currentuserid = _userManager.GetUserId(HttpContext.User);
            ApplicationUser currentuser = _userManager.FindByIdAsync(currentuserid).Result;
            
            //Get receiver end user details
            ApplicationUser user = await _userManager.FindByIdAsync(accountViewModel.DepositToUserId);
            user.BalanceAmount = user.BalanceAmount + accountViewModel.DepositAmount;
            Transaction transac = new Transaction();
            transac.Datetime = DateTime.Now;
            transac.Userid = currentuser.Id;
            transac.Narration = "You have deposited to "+ user.Email;
            transac.Deposit = accountViewModel.DepositAmount;
            transac.ClosingBalance = currentuser.BalanceAmount - accountViewModel.DepositAmount;
            currentuser.BalanceAmount = currentuser.BalanceAmount - accountViewModel.DepositAmount;
            _appDbContext.Update(user);
            _appDbContext.Update(transac);
            _appDbContext.Update(currentuser);
            _appDbContext.SaveChanges();

            UpdateReceiverchanges(user, currentuser, accountViewModel);
            return View();
        }

        private void UpdateReceiverchanges(ApplicationUser user, ApplicationUser currentuser,AccountViewModel accountViewModel)
        {
            Transaction transac = new Transaction();
            transac.Datetime = DateTime.Now;
            transac.Userid = user.Id;
            transac.Narration = currentuser.UserName + " has deposited";
            transac.Deposit = accountViewModel.DepositAmount;
            transac.ClosingBalance = user.BalanceAmount;
            _appDbContext.Update(transac);
            _appDbContext.SaveChanges();
        }

        public IActionResult MiniStatement()
        {
            Transaction transac = new Transaction();
            var userid = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userid).Result;
            List<Transaction> transactionlist = _appDbContext.transactions.Where(a => a.Userid == user.Id).ToList();
            return View(transactionlist);
        }
        public ViewResult Recharge()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Recharge(AccountViewModel accountViewModel)
        {
            var userid = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userid).Result;
            user.BalanceAmount = user.BalanceAmount - accountViewModel.RechargeAmount;
            Transaction transac = new Transaction
            {
                Datetime = DateTime.Now,
                Userid = user.Id,
                Narration = "Recharge " + accountViewModel.Network + "-" + accountViewModel.MobileNumber,
                Withdrawl = accountViewModel.RechargeAmount,
                ClosingBalance = user.BalanceAmount
            };
            _appDbContext.Update(user);
            _appDbContext.Update(transac);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
