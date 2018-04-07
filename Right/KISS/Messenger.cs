using System.Collections.Generic;
using System.Linq;

namespace QualitiOfCode.Right.KISS
{
    public class Messenger
    {
        private List<Message> _History;

        public Messenger()
        {
            _History = new List<Message>();
        }

        public void SendMessage(Contact from, Contact to, string messageText)
        {
            var message = new Message(from, to, messageText);
            _History.Add(message);
        }

        public IEnumerable<string> GetConversation(Contact contact)
        {
            return _History
                .Where(item => item.From.Id == contact.Id ||
                               item.To.Id == contact.Id)
                .OrderBy(order => order.Date)
                .Select(o => o.ToString());
        }
    }
}
