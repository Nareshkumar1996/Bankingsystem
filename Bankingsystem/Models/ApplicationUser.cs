using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bankingsystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int BalanceAmount { get; set; }
        public int Age { get; set; }
    }
}
