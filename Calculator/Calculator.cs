using System;

namespace SByteStream.Samples
{
    public class Calculator
    {
        public int Add(int a, int b) 
        {
            return a + b;
        }

        public int Subtract(int a, int b) 
        {
            return a + b;
        }

        public int Multiply(int a, int b) 
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {            
            if (b == 0) throw new ArgumentOutOfRangeException("Divisor cannot be zero");
            return a / b;
        }
    }
}
