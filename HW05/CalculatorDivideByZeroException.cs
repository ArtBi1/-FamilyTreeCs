using System.Runtime.Serialization;

namespace HW05
{/*
     * Доработайте реализацию калькулятора разработав собственные типы  ошибок.
    CalculatorDivideByZeroException
    CalculateOperationCauseOverflowException
    */
    internal class CalculatorDivideByZeroException : Exception
    {
        public CalculatorDivideByZeroException(string message) : base(message)
        {

        }

    }
}