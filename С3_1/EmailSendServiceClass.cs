using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Security;

namespace С3_1
{
    public class EmailSendServiceClass
    {
        //public EmailSendServiceClass(int smtp_port, string smtp_host)
        //{
        //    DataClass.smtp_port = smtp_port;
        //    DataClass.smtp_host = smtp_host;
        //}
        public void SmtpSender(int smtp_port, string smtp_host, string user_name, SecureString password, MailMessage message)
        {
            using (var client = new SmtpClient(smtp_host, smtp_port))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(user_name, password);
                client.Send(message);
            }                        
        }
    }
}
