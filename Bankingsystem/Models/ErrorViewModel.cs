using Bankingsystem.Data;
using Microsoft.AspNetCore.Identity;
using System;

namespace Bankingsystem.Models
{
    public class ErrorViewModel
    {
       
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
       
    }
}
