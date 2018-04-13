using Builder.Builders.Contract;
using System;

namespace Builder
{
    class Program
    {
        public static void Main()
        {
            AVehicleBuilder builder;

            Shop shop = new Shop();

            builder = new ScooterBuilder();
            shop.Construct(builder);
            Console.WriteLine("---------------------------");
            Console.WriteLine(builder.Vehicle);

            builder = new CarBuilder();
            shop.Construct(builder);
            Console.WriteLine("\r\n---------------------------");
            Console.WriteLine(builder.Vehicle);

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            Console.WriteLine("\r\n---------------------------");
            Console.WriteLine(builder.Vehicle);

            Console.ReadKey();
        }
    }
}