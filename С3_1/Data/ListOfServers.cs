using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С3_1.Data
{
    public class ListOfServers
    {
        public static List<Servers> Server = new List<Servers>
        {
            new Servers("smtp.yandex.ru"),
            new Servers("smtp.mail.ru"),
            new Servers("smtp.google.com")
        };
    }
}
