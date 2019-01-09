using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace С3_1.Data
{
    public class MailServers
    {
        public static Dictionary<Servers, Ports> Servers { get; } = new Dictionary<Servers, Ports>
        {
            Servers.Add(new Servers("smtp.yandex.ru"), new Ports(25)),
            Servers.Add(new Servers("smtp.mail.ru"), new Ports(25)),
            Servers.Add(new Servers("smtp.google.com"), new Ports(465)),
        };
    }
}
