using System;
using System.Collections.Generic;

namespace QualityOfCode.KISS.Wrong
{
    public class Contact
    {
        public string Name { get; set; }
        public List<Tuple<DateTime, Contact, string>> Messages { get; set; }

        public Contact(string name)
        {
            Name = name;
            Messages = new List<Tuple<DateTime, Contact, string>>();
        }

        public void SendMessage(Contact to, string message)
        {
            to.AddMessage(this, message);
        }

        public void AddMessage(Contact from, string message)
        {
            Messages.Add(new Tuple<DateTime, Contact, string>(DateTime.Now, from, message));
        }
    }
}
