using System;

namespace Seminar.Model
{
    public class Bits
    {
        private readonly int value;

        public Bits(int value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return Convert.ToString(value, 2);
        }

        public static implicit operator Bits(long value) // из long -> bits
        {
            return new Bits((int)value);
        }

        public static implicit operator Bits(int value) // из int -> bits
        {
            return new Bits(value);
        }

        public static implicit operator Bits(byte value) // из byte -> bits
        {
            return new Bits(value);
        }
    }
}



