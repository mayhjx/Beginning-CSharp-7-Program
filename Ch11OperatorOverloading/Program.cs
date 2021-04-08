using System;

namespace Ch11OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            AddClasss1 op1 = new AddClasss1();
            op1.val = 5;
            AddClasss1 op2 = new AddClasss1();
            op2.val = 5;
            AddClasss1 op3 = op1 + op2;
            Console.WriteLine(op3);
            Console.WriteLine(-op3);
        }
    }

    public class AddClasss1
    {
        public int val;
        public static AddClasss1 operator +(AddClasss1 op1, AddClasss1 op2)
        {
            AddClasss1 returnVal = new AddClasss1();
            returnVal.val = op1.val + op2.val;
            return returnVal;
        }
        public static AddClasss1 operator -(AddClasss1 op1)
        {
            AddClasss1 returnVal = new AddClasss1();
            returnVal.val = -op1.val;
            return returnVal;
        }

        public static bool operator >=(AddClasss1 op1, AddClasss1 op2)
        {
            return op1.val >= op2.val;
        }
        public static bool operator <=(AddClasss1 op1, AddClasss1 op2)
        {
            return !(op1 >= op2);
        }

        public static bool operator >(AddClasss1 op1, AddClasss1 op2)
        {
            return op1.val > op2.val;
        }
        public static bool operator <(AddClasss1 op1, AddClasss1 op2)
        {
            return !(op1 > op2);
        }

        public static bool operator ==(AddClasss1 op1, AddClasss1 op2)
        {
            return op1.val == op2.val;
        }
        public static bool operator !=(AddClasss1 op1, AddClasss1 op2)
        {
            return !(op1 == op2);
        }

        public override bool Equals(object op1)
        {
            if(op1 is AddClasss1)
            {
                return val == ((AddClasss1)op1).val;
            }
            else
            {
                throw new ArgumentException(
                    "Cannot compare AddClass1 objects with objects of type " +
                    op1.GetType().ToString());
            }
        }
        public override int GetHashCode()
        {
            return val;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }
}
