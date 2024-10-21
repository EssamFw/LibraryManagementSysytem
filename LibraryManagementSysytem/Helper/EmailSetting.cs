using System.Net.Mail;
using System.Net;

namespace LibraryManagementSysytem.Helper
{
    public static class EmailSetting
    {
        public static void SendEmail(SendEmail input)
        {
            var client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("abdelsalamm789@gmail.com", "ubzgywfwgbygange");
            client.Send("abdelsalamm789@gmail.com", input.To, input.Subject, input.Body);
        }
    }
}
