using System.Runtime.Serialization;

namespace HW05
{
    internal class CalculateOperationCauseOverflowException : Exception
    {
        public CalculateOperationCauseOverflowException(string message) : base(message)
        {

        }
    }
}