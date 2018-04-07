using System;
using System.Collections.Generic;
using System.Linq;

namespace QualityOfCode.Wrong.KISS
{
    public class Messenger
    {
        public void SendMessageToContact(Contact from, Contact to, string message)
        {
            from.SendMessage(to, message);
        }

        public List<Tuple<DateTime, Contact, string>> GetMessages(Contact contact)
        {
            return contact.Messages.Select(o => new Tuple<DateTime, Contact, string> (o.Item1, contact, o.Item3)).ToList();
        }
    }
}
