using System;

namespace Ch06Ex64
{
    class Program
    {
        struct order
        {
            public string itemName;
            public int unitCount;
            public double unitCost;
            public double Total() => unitCost * unitCount;
            public string Print() => $"Order Information: {unitCount} " +
                $"{itemName} items at ${unitCost} each, " +
                $"total cost ${Total()}";
        }
        static void Main(string[] args)
        {
            order order;
            order.itemName = "A";
            order.unitCount = 10;
            order.unitCost = 1.5;

            Console.WriteLine($"Total price of order: {order.Total()}");
            Console.WriteLine(order.Print());
        }
    }
}
