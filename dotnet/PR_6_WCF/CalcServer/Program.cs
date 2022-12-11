using System;
using System.ServiceModel;

namespace CalcServer
{
    public class Program
    {
        public static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(CalcService)))
            {
                host.Open();
                Console.WriteLine("Server started");
                Console.WriteLine("Press <Enter> to close!!!");
                Console.ReadLine();
            }
        }
    }
}
