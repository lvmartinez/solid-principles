using System;

namespace SOLID.SRP
{
    public class SendMessage
    {
        public void SendEmail(string email)
        {
            Console.WriteLine($"Sending email to {email}");
            //code to send email;
        }
    }
}