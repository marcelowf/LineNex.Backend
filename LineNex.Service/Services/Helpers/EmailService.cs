using LineNex.Service.Interfaces.Helpers;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Threading.Tasks;

namespace LineNex.Service.Services.Helpers
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;
        private readonly string _templatePath;

        public EmailService(IConfiguration config)
        {
            _config = config;
            _templatePath = Path.Combine(AppContext.BaseDirectory, "Services", "Helpers", "Templates", "EmailLayout.html");
        }

        public async Task SendEmailAsync(string toEmail, string subject, string htmlBodyContent)
        {
            Console.WriteLine($"[DEBUG] Template path: {_templatePath}");
            var fullHtml = await WrapWithTemplateAsync(htmlBodyContent);

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("LineNex", _config["EmailSettings:FromEmail"]));
            message.To.Add(new MailboxAddress("", toEmail));
            message.Subject = subject;
            message.Body = new TextPart("html") { Text = fullHtml };

            using var client = new SmtpClient();
            client.Timeout = 10000;

            await client.ConnectAsync(
                _config["EmailSettings:SmtpHost"],
                int.Parse(_config["EmailSettings:SmtpPort"]),
                MailKit.Security.SecureSocketOptions.StartTls);

            await client.AuthenticateAsync(
                _config["EmailSettings:FromEmail"],
                _config["EmailSettings:Password"]);

            await client.SendAsync(message);
            await client.DisconnectAsync(true);
        }

        private async Task<string> WrapWithTemplateAsync(string content)
        {
            Console.WriteLine($"[DEBUG] Template path: {_templatePath}");
            var template = await File.ReadAllTextAsync(_templatePath);
            return template.Replace("{{BODY_CONTENT}}", content);
        }
    }
}
