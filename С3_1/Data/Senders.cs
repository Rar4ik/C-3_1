using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С3_1.Data
{
    public class Senders
    {
        public string Name { get; set; }
        public string Adress { get; set; }        
        public Senders(string name, string adress)
        {
            Name = name;
            Adress = adress;
        }
    }
}
