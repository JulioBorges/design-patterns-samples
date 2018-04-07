using QualitiOfCode.Right.KISS;
using System;

namespace QualityOfCode.Right
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contact julio = new Contact("Julio");
            Contact vanessa = new Contact("Vanessa");
            Messenger messenger = new Messenger();

            messenger.SendMessage(vanessa, julio, "Por favor compre arroz !!!");
            messenger.SendMessage(julio, vanessa, "OK");
            messenger.SendMessage(julio, vanessa, "Mais alguma coisa?");
            messenger.SendMessage(vanessa, julio, "Traz chocolate também ;-)");

            var messagesInDialog = messenger.GetConversation(julio);

            foreach (var msg in messagesInDialog)
            {
                Console.WriteLine(msg);
            }

            Console.WriteLine("*****");
            Console.Read();
        }
    }
}
