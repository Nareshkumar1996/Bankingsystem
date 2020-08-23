using Bankingsystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bankingsystem.ViewModels
{
    public class AccountViewModel
    {
        public ApplicationUser applicationUser { get; set; }
        public int WithdrawAmount { get; set; }

        [Required]        
        public int DepositAmount { get; set; }
        public string DepositToUserId { get; set; }
        public List<Transaction> transaction { get; set; }
        public string MobileNumber { get; set; }
        public string Network { get; set; }
        public int RechargeAmount { get; set; }
        public static IEnumerable<SelectListItem> GetNetworkList()
        {
            List<SelectListItem> network = new List<SelectListItem>();
            network.Add(new SelectListItem
            {
                Value = "Airtel",
                Text = "Airtel"
            });
            network.Add(new SelectListItem
            {
                Value = "Vodafone",
                Text = "Vodafone"
            });
            network.Add(new SelectListItem
            {
                Value = "Jio",
                Text = "Jio"
            });
            return network;
        }
    }
}
