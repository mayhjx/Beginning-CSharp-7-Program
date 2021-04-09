
using System;

namespace Ch11Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvClass1 op1 = new ConvClass1();
            op1.val = 3;
            ConvClass2 op2 = op1;
            Console.WriteLine(op2.val);

            ConvClass2 op3 = new ConvClass2();
            op3.val = 3e5;
            ConvClass1 op4 = (ConvClass1)op3;
            Console.WriteLine(op4.val);
        }
    }

    public class ConvClass1
    {
        public int val;
        public static implicit operator ConvClass2(ConvClass1 op1)
        {
            ConvClass2 returnVal = new ConvClass2();
            returnVal.val = op1.val;
            return returnVal;
        }
    }

    public class ConvClass2
    {
        public double val;
        public static explicit operator ConvClass1(ConvClass2 op1)
        {
            ConvClass1 returnVal = new ConvClass1();
            checked { returnVal.val = (int)op1.val; };
            return returnVal;
        }
    }

}
