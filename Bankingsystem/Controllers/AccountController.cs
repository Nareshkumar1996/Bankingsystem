﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Bankingsystem.Constants;
using Bankingsystem.Data;
using Bankingsystem.Models;
using Bankingsystem.Services;
using Bankingsystem.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bankingsystem.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly IAccountService _accountService;

        public AccountController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager, IEmailSender emailSender, IAccountService accountService)
        {
            _appDbContext = applicationDbContext;
            _userManager = userManager;
            _emailSender = emailSender;
            _accountService = accountService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var user = _accountService.FindUserById().Result;

            return View(user);
        }
        public IActionResult GetBalance()
        {
            var user = _accountService.FindUserById().Result;

            return View(user);
        }
        public ViewResult Depositform()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Deposit(AccountViewModel accountViewModel)
        {
                var user = _accountService.FindUserById().Result;
                user.BalanceAmount = user.BalanceAmount + accountViewModel.DepositAmount;

                var transaction = _accountService.MapTransaction(user.Id, ApplicationConstants.Deposited, 0,
                    accountViewModel.DepositAmount, user.BalanceAmount);

                _appDbContext.Update(user);
                _appDbContext.Update(transaction);
                _appDbContext.SaveChanges();
                return View(accountViewModel);
            
        }
        public ViewResult Withdrawform()
        {
            return View();
        }
        public IActionResult Withdraw(AccountViewModel accountViewModel)
        {
            var user = _accountService.FindUserById().Result;
            user.BalanceAmount = user.BalanceAmount - accountViewModel.WithdrawAmount;

            var transaction = _accountService.MapTransaction(user.Id, ApplicationConstants.Withdrawn,
                accountViewModel.WithdrawAmount, 0, user.BalanceAmount);

            _appDbContext.Update(user);
            _appDbContext.Update(transaction);
            _appDbContext.SaveChanges();
            return View(accountViewModel);

        }
        public ViewResult Details()
        {
            var user = _accountService.FindUserById().Result;
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
            Transaction transac = new Transaction
            {
                Datetime = DateTime.Now,
                Userid = currentuser.Id,
                Narration = "You have deposited to " + user.Email,
                Deposit = accountViewModel.DepositAmount,
                ClosingBalance = currentuser.BalanceAmount - accountViewModel.DepositAmount
            };
            currentuser.BalanceAmount = currentuser.BalanceAmount - accountViewModel.DepositAmount;
            _appDbContext.Update(user);
            _appDbContext.Update(transac);
            _appDbContext.Update(currentuser);
            _appDbContext.SaveChanges();

            UpdateReceiverchanges(user, currentuser, accountViewModel);
            ViewBag.result = "Money Transfered Successfully!";
            return View();
        }

        private void UpdateReceiverchanges(ApplicationUser user, ApplicationUser currentuser,AccountViewModel accountViewModel)
        {
            Transaction transac = new Transaction
            {
                Datetime = DateTime.Now,
                Userid = user.Id,
                Narration = currentuser.UserName + " has deposited",
                Deposit = accountViewModel.DepositAmount,
                ClosingBalance = user.BalanceAmount
            };
            _appDbContext.Update(transac);
            _appDbContext.SaveChanges();
        }

        public IActionResult MiniStatement()
        {
            Transaction transac = new Transaction();
            
            var user = _accountService.FindUserById().Result;
            List<Transaction> transactionlist = _appDbContext.transactions.Where(a => a.Userid == user.Id).ToList();
            //AccountViewModel accountViewModel = new AccountViewModel();            
            //accountViewModel.transaction = transactionlist;
            return View(transactionlist);
        }
        public ViewResult Recharge()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Recharge(AccountViewModel accountViewModel)
        {
            var user = _accountService.FindUserById().Result;
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

            return RedirectToAction("RechargeSuccess", accountViewModel);
        }
        public IActionResult RechargeSuccess(AccountViewModel accountViewModel)
        {
            return View(accountViewModel);
        }
        public IActionResult AllUsers()
        {
            List<ApplicationUser> allusers = new List<ApplicationUser>();
            allusers =  _userManager.Users.ToList();
            return View(allusers);
        }
        public async Task<IActionResult> MoreDetails(string id)
        {
           var user = await _userManager.FindByIdAsync(id);
            return View(user);
        }
        
        public async Task<IActionResult> EmailConfirm(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var confirmationLink = Url.Action("ActivateUserEmail", "Account",
                new { userId = user.Id, token = token }, Request.Scheme);
            await _emailSender.SendEmailAsync(email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(confirmationLink)}'>clicking here</a>.");
            System.Diagnostics.Debug.WriteLine("Confirmation = "+confirmationLink);
            user.Status = "Pending";
            _appDbContext.Update(user);
            _appDbContext.SaveChanges();

            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> ActivateUserEmail(string userId, string token)
        {
            if(userId == null || token == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if(user == null)
            {
                return View("User Not Found");
            }
            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                user.Status = "Activated";
                _appDbContext.Update(user);
                _appDbContext.SaveChanges();
                return View();
            }

            return View();
        }
    }
}
