using QualityOfCode.KISS.Wrong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QualityOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            KissExample();
        }

        private static void KissExample()
        {
            Contact vanessa = new Contact("Julio");
            Contact julio = new Contact("Vanessa");
            Messenger messenger = new Messenger();

            vanessa.SendMessage(julio, "Por favor compre arroz !!!");
            Thread.Sleep(100);

            messenger.SendMessageToContact(vanessa, julio, "OK");
            Thread.Sleep(100);

            julio.SendMessage(vanessa, "Mais alguma coisa?");
            Thread.Sleep(100);

            messenger.SendMessageToContact(vanessa, julio, "Traz chocolate também");
            Thread.Sleep(100);

            var messagesInDialog = messenger.GetMessages(julio);
            messagesInDialog.AddRange(messenger.GetMessages(vanessa));

            foreach (var msg in messagesInDialog.OrderBy(o => o.Item1))
            {
                Console.WriteLine($"{msg.Item1:dd/MM/yyyy - HH:mm:ss:fff} - {msg.Item2.Name} disse: {msg.Item3}");
            }

            Console.WriteLine("*****");
            Console.Read();
        }
    }
}
