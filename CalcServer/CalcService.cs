using CalcInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcServer
{
    public class CalcService : ICalcService
    {
        public float Div(int firstNumber, int secondNumber)
        {
            return (float)firstNumber / (float)secondNumber;
        }
        public int Mod(int firstNumber, int secondNumber)
        {
            return firstNumber % secondNumber;
        }
        public int Mul(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
