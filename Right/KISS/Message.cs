using System;

namespace QualitiOfCode.Right.KISS
{
    public class Message
    {
        public Guid Id { get; private set; }
        public Contact From { get; private set; }
        public Contact To { get; private set; }
        public string MessageText { get; private set; }
        public DateTime Date { get; private set; }

        public Message(Contact from, Contact to, string messageText)
        {
            Id = Guid.NewGuid();
            From = from;
            To = to;
            MessageText = messageText;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Date:dd/MM/yyyy-HH:mm:ss:ffffff} | {From} disse: {MessageText}";
        }
    }
}
