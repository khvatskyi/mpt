using CalcInterfaces;

namespace CalcServer
{
    public class CalcService : ICalcService
    {
        public int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        public int Power(int number, int power)
        {
            if (power == 0)
            {
                return 1;
            }

            return number * Power(number, power - 1);
        }
    }
}
