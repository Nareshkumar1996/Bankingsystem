using Bankingsystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bankingsystem.ViewModels
{
    public class AccountViewModel
    {
        public ApplicationUser applicationUser { get; set; }
        public int WithdrawAmount { get; set; }
        public int DepositAmount { get; set; }
    }
}
