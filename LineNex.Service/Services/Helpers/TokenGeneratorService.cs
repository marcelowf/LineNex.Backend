using LineNex.Service.Interfaces.Helpers;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LineNex.Service.Services.Helpers
{
    public class TokenGeneratorService : ITokenGeneratorService
    {
        public string Generate()
        {
            var bytes = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            // URL-safe
            return Convert.ToBase64String(bytes).TrimEnd('=').Replace('+', '-').Replace('/', '_');
        }
    }
}
