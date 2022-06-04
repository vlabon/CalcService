using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalcInterfaces
{
    [ServiceContract]
    public interface ICalcService
    {
        [OperationContract]
        int Sum(int firstNumber, int secondNumber);

        [OperationContract]
        int Sub(int firstNumber, int secondNumber);

        [OperationContract]
        int Mul(int firstNumber, int secondNumber);

        [OperationContract]
        float Div(int firstNumber, int secondNumber);

        [OperationContract]
        int Mod(int firstNumber, int secondNumber);
    }
}
