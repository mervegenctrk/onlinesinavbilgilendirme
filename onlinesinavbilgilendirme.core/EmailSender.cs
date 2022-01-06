using onlinesinavbilgilendirme.core.Model;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace onlinesinavbilgilendirme.core
{
    public class EmailSender
    {
        public bool SendEmail(Email email)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("cantach@hotmail.com");
            mailMessage.To.Add(new MailAddress(email.UserEmail));

            mailMessage.Subject = email.Subject;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = email.Body;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("cf679e74fb61c3b9c8aa13c5c11b3f70", "4aee41cc62071f876110b78cf0e1534c");
            client.Host = "in-v3.mailjet.com";
            client.Port = 587;

            try
            {
                client.Send(mailMessage);
                return true;
            }
            catch (Exception)
            {
                // log exception
            }
            return false;
        }
    }
}
