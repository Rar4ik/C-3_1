using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Diagnostics;

//namespace С3_1
//{
//    public class EmailSendServiceClass
//    {
//        private string _SmtpHost;
//        private int _SmtpPort;
//        private bool _UseSSL;
//        private string _UserName;
//        private SecureString _Password;
//        public EmailSendServiceClass(string smtphost, int smtport, bool ssl, string username, SecureString password)
//        {
//            _SmtpHost = smtphost;
//            _SmtpPort = smtport;
//            _UseSSL = ssl;
//            _UserName = username;
//            _Password = password;
//         }
//        public void SmtpSender(string Subject, string Email, string Adress)
//        {
//            using (var message = new MailMessage(_UserName, Adress))
//            {
//                message.Subject = Subject;
//                message.Body = Email;
//                using (var client = new SmtpClient(_SmtpHost, _SmtpPort))
//                {
//                    client.EnableSsl = _UseSSL;
//                    client.Credentials = new NetworkCredential(_UserName, _Password);
//                    try
//                    {
//                        client.Send(message);
//                    }
//                    catch (Exception e)
//                    {
//                        Trace.TraceError(e.Message);
//                        Trace.TraceError(e.ToString());
//                    }                    
//                }
//            }
                                  
//        }
//    }
//}
