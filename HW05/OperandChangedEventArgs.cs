using System;

namespace HW05
{
    public class OperandChangedEventArgs : EventArgs
    {
        public double Operand { get; }

        public OperandChangedEventArgs(double operand)
        {
            Operand = operand;
        }
    }
}
