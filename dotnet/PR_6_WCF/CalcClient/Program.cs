using System;
using System.ServiceModel;
using CalcInterfaces;

namespace CalcClient
{
    public class Program
    {
        public static void Main()
        {
            ChannelFactory<ICalcService> channel = new ChannelFactory<ICalcService>("CalcServiceEndpoint");

            ICalcService proxy = channel.CreateChannel();

            Console.WriteLine($"Sum is {proxy.Sum(4, 2)}");
            Console.WriteLine($"Subtraction is {proxy.Subtract(4, 2)}");
            Console.WriteLine($"Multiply result is {proxy.Multiply(4, 2)}");
            Console.WriteLine($"Divide is {proxy.Divide(4, 2)}");
            Console.WriteLine($"Power is {proxy.Power(4, 2)}");
            Console.ReadLine();
        }
    }
}
