using System;

namespace Ch11Cloner
{
    class Program
    {
        static void Main(string[] args)
        {
            // shallow copy
            ValueTypeCloner source = new ValueTypeCloner(1);
            ValueTypeCloner target = (ValueTypeCloner)source.GetCopy();
            Console.WriteLine($"target.Val = {target.Val}");
            source.Val = 2;
            Console.WriteLine($"After change source.Val, target.Val = {target.Val}");
            Console.WriteLine();

            // shallow copy
            ReferenceTypeCloner sourceReferenceTypeCloner = new(5);
            ReferenceTypeCloner targetReferenceTypeCloner = (ReferenceTypeCloner)sourceReferenceTypeCloner.GetCopy();
            Console.WriteLine($"targetReferenceTypeCloner.MyContent.Val = " +
                $"{targetReferenceTypeCloner.MyContent.Val}");
            sourceReferenceTypeCloner.MyContent.Val = 2;
            Console.WriteLine($"After change source.MyContent.Val, " +
                $"targetReferenceTypeCloner.MyContent.Val = " +
                $"{targetReferenceTypeCloner.MyContent.Val}");
            Console.WriteLine();

            // deep copy
            DeepCopyCloner source1 = new(5);
            DeepCopyCloner target1 = (DeepCopyCloner)source1.Clone();
            Console.WriteLine($"target1.MyContent.Val = " +
                $"{target1.MyContent.Val}");
            source1.MyContent.Val = 2;
            Console.WriteLine($"After change source1.MyContent.Val, " +
                $"target1.MyContent.Val = " +
                $"{target1.MyContent.Val}");
        }
    }

    public class ValueTypeCloner
    {
        public int Val;
        public ValueTypeCloner(int newVal) => Val = newVal;
        public object GetCopy() => MemberwiseClone();
    }

    public class ReferenceTypeCloner
    {
        public Content MyContent = new Content();
        public ReferenceTypeCloner(int newVal) => MyContent.Val = newVal;
        public object GetCopy() => MemberwiseClone();
    }
    public class Content
    {
        public int Val;
    }

    public class DeepCopyCloner:ICloneable
    {
        public Content MyContent = new Content();
        public DeepCopyCloner(int newVal) => MyContent.Val = newVal;

        public object Clone()
        {
            DeepCopyCloner deepCopyCloner = new DeepCopyCloner(MyContent.Val);
            return deepCopyCloner;
        }
    }
}
