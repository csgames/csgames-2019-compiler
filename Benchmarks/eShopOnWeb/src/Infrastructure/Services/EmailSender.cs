﻿using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.Infrastructure.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message) // @issue@I02 // @issue@I04
        {
            // TODO: Wire this up to actual email sending logic via SendGrid, local SMTP, etc.
            return Task.CompletedTask; // @issue@I02
        }
    }
}
