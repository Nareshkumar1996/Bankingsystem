using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bankingsystem.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bankingsystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        public AccountController(ApplicationDbContext applicationDbContext)
        {
            _appDbContext = applicationDbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetBalance(int id)
        {
            var balance = _appDbContext.Users.FirstOrDefault(a => a.Id == id.ToString());
            System.Diagnostics.Debug.WriteLine(balance.UserName);
            ViewBag.message = balance.UserName;
            return View(balance);
        }
    }
}
