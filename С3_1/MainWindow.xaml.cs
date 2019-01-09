using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Mail;
using System.Security;

namespace С3_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var a = new EmailSender.EmailSendServiceClass
            
        }

        private void MenuItem_ClickExit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LetterSend(object sender, RoutedEventArgs e)
        {
            try
            {
                //var sender_name = SenderName.Text;
                //var reciever_name = RecieverName.Text;
                //var password = UserPassword.SecurePassword;
                //var subject = Subject.Text;
                //var body = Body.Text;

                //using (var message = new MailMessage
                //    (sender_name, reciever_name))
                //{
                //    message.Subject = subject;
                //    message.Body = body;
                //    EmailSendServiceClass email = new EmailSendServiceClass();
                //    email.SmtpSender(DataClass.smtp_port, DataClass.smtp_host,
                //        sender_name, password, message);
                //}
                var success_dlg = new SuccessWindow();
                success_dlg.ShowDialog();
            }
            catch (Exception error)
            {
                var error_dlg = new ErrorWindow();
                error_dlg.ShowDialog();
            }

        }

        private void BtnCLickToTheScheduler(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedItem = tabScheduler;
        }

        private void OnSendButtonClick(object sender, RoutedEventArgs e)
        {
            var server = Servers.SelectedItem as Data.MailServers;
            string server1 = null;
            int port = 25;
            bool ssl = true;
            string user = null;
            SecureString password = null;
            //var send_message_service = new EmailSendServiceClass(server, port, ssl, user, password);
        }
    }
}
