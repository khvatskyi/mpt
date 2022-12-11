using System.ServiceModel;

namespace CalcInterfaces
{
    [ServiceContract]
    public interface ICalcService
    {
        [OperationContract]
        int Sum(int firstNumber, int secondNumber);

        [OperationContract]
        int Subtract(int firstNumber, int secondNumber);

        [OperationContract]
        int Multiply(int firstNumber, int secondNumber);

        [OperationContract]
        int Divide(int numerator, int denominator);

        [OperationContract]
        int Power(int number, int power);
    }
}
