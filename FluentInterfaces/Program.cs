using FluentInterfaces.Documents;
using System;

namespace FluentInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order;

            // Without Fluent:
            order = new Order();
            order.SetTitle("New Order");
            order.SetHeader("Start");
            order.AddLine("1");
            order.AddLine("2");
            order.AddLine("3");
            order.AddLine("4");
            order.AddLine("5");
            order.SetFooter("End");

            Console.WriteLine(order.ReadDocument());
            Console.WriteLine();
            Console.WriteLine();

            //With Fluent:
            order = new Order();
            order
                .SetTitle("New Order")
                .SetHeader("Start")
                .AddLine("1")
                .AddLine("2")
                .AddLine("3")
                .AddLine("4")
                .AddLine("5")
                .SetFooter("End");

            Console.WriteLine(order.ReadDocument());

            Console.Read();
        }
    }
}
