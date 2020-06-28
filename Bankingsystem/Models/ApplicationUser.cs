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
        public string Status { get; set; }
        public string  Address { get; set; }
        public string MartialStatus { get; set; }
        public string Gender { get; set; }
        public int Pincode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string NearestBranch { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int AadhaarNo { get; set; }

    }
}
