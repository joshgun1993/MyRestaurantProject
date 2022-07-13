﻿using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ByJoshgunFinalRestaurantProject.Helpers
{
   

    public static class Helper
    {
        public enum Roles
        {
            SuperAdmin,
            Admin
        }

        public static async Task SendMessage(string messageSubject, string messageBody, string mailTo)
        {

            SmtpClient client = new SmtpClient("smtp.yandex.com", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("coshqun.n@itbrains.az", "ajeqwajtmgjehcgk");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            MailMessage message = new MailMessage("coshqun.n@itbrains.az", mailTo);
            message.Subject = messageSubject;
            message.Body = messageBody;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;

            await client.SendMailAsync(message);

        }



    }


    

}
