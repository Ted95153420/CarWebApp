using System.Diagnostics;

namespace CarPriceComparison.Services
{
    public class DebugMailService : IMailService
    {
        public void SendMail(string to, string from, string subject, string body)
        {
            Debug.WriteLine($"Sending Mail to : {to}, from : {from}, subject : {subject}");
        }
    }
}