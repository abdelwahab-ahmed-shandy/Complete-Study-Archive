using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;
using System.Net;

namespace MovieMart.Utility
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            if (false)
            {
                using var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("your_email@gmail.com", "your_password"),
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };

                using var mailMessage = new MailMessage
                {
                    From = new MailAddress("your_email@gmail.com", "MovieMart"),
                    Subject = subject,
                    Body = message,
                    IsBodyHtml = true
                };

                mailMessage.To.Add(email);
                await client.SendMailAsync(mailMessage);
            }

            Console.WriteLine("Email sending is currently disabled.");
        }
    }
}

