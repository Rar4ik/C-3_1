using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace С3_1.Data
{
    public class MailSenders
    {
        public static ObservableCollection<Senders> Senders = new ObservableCollection<Senders>
        {
            new Senders("Yarik", "yarik@mail.ru"),
            new Senders("nnemov", "nnemov@mail.ru")
        };
    }
}
