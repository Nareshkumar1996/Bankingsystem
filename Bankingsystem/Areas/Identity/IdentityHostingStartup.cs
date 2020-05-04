using System;
using Bankingsystem.Data;
using Bankingsystem.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Bankingsystem.Areas.Identity.IdentityHostingStartup))]
namespace Bankingsystem.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddTransient<IEmailSender, EmailSender>(i =>
                    new EmailSender(
                        context.Configuration["EmailSender:Host"],
                        context.Configuration.GetValue<int>("EmailSender:Port"),
                        context.Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                        context.Configuration["EmailSender:UserName"],
                        context.Configuration["EmailSender:Password"],
                        context.Configuration["EmailSender:FromEmail"]
                    )
                );
            });
        }
    }
}