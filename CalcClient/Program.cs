using CalcInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalcClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<ICalcService> channel = new ChannelFactory<ICalcService>("CalcServiceEndpoint");
            ICalcService proxy = channel.CreateChannel();
            int res = proxy.Sum(5, 4);

            Console.WriteLine($"Sumn is {res}");
            Console.ReadLine();
        }
    }
}
