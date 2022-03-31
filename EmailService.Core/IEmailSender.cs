using EmailService.Core.Contracts;
using System;
using System.Threading.Tasks;

namespace EmailService.Core
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(EmailMessage message);
    }
}
