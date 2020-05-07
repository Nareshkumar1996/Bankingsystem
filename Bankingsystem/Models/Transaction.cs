using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bankingsystem.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        public string Userid { get; set; }
        public DateTime Datetime { get; set; }
        public string Narration { get; set; }
        public int Withdrawl { get; set; }
        public int Deposit { get; set; }
        public int ClosingBalance { get; set; }
    }
}
