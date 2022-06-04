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
            
            bool running = true;
            while(running)
            {
                int firstNumber;
                int secondNumber;

                Console.WriteLine("Enter first number: ");
                if(!int.TryParse(Console.ReadLine(), out firstNumber))
                {
                    Console.WriteLine("Number is invalid!\n");
                    continue;
                }

                Console.WriteLine("Enter second number: ");
                if(!int.TryParse(Console.ReadLine(), out secondNumber))
                {
                    Console.WriteLine("Number is invalid!\n");
                    continue;
                }

                Console.WriteLine("Choose operation:");
                Console.WriteLine("1. Sum (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multipication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Modulo (%)");
                Console.WriteLine("6. Exit...");
                Console.WriteLine();

                Console.WriteLine("Enter operation number: ");
                string op = Console.ReadLine();
                Console.WriteLine();

                switch (op[0])
                {
                    case '1':
                        Console.WriteLine("Sum ({0} + {1}) = {2}", firstNumber, secondNumber,
                            proxy.Sum(firstNumber, secondNumber));
                        break;
                    case '2':
                        Console.WriteLine("Subtraction ({0} - {1}) = {2}", firstNumber, secondNumber,
                            proxy.Sub(firstNumber, secondNumber));
                        break;
                    case '3':
                        Console.WriteLine("Multipication ({0} * {1}) = {2}", firstNumber, secondNumber,
                            proxy.Mul(firstNumber, secondNumber));
                        break;
                    case '4':
                        Console.WriteLine("Division ({0} / {1}) = {2}", firstNumber, secondNumber,
                            proxy.Div(firstNumber, secondNumber));
                        break;
                    case '5':
                        Console.WriteLine("Mod ({0} % {1}) = {2}", firstNumber, secondNumber,
                            proxy.Mod(firstNumber, secondNumber));
                        break;
                    case '6':
                        Console.WriteLine("Exitting...");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid operation!");
                        break;
                }
            }
        }
    }
}
