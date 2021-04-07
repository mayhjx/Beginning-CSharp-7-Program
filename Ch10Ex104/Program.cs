using System;

namespace Ch10Ex104
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyCopyableClass();
            myClass.Text = "Test 1";

            var myCopyableClass = myClass.GetCopy();

            myClass.Text = "Test 2";

            Console.WriteLine(myClass.Text);
            Console.WriteLine(myCopyableClass.Text);
            // 虽然string是reference类型，但也是不可修改的（immutable），
            // 开始时，myCopyableClass的Text的值和myClass是指向同一块堆的，其中的值是Test 1
            // 但是当myClass修改Test的值的时候，他指向了另一块内存堆，
            // 此时myCopyableClass的指向不变，还是Test 1
            // https://stackoverflow.com/questions/506648/how-do-strings-work-when-shallow-copying-something-in-c
        }
    }

    class MyCopyableClass
    {
        public string Text { get; set; }
        public MyCopyableClass GetCopy()
        {
            return (MyCopyableClass)this.MemberwiseClone();
        }
    }
}
