using System;

namespace DesignPattern.Creational.Prototype
{
    class PrototypeProgram
    {
        public static void Work()
        {
            // Language agnostic solution
            var supermarket = new Supermarket();

            supermarket.AddProduct("Milk", new Milk(0.89m));
            supermarket.AddProduct("Bread", new Bread(1.10m));

            decimal sourcePrice;
            decimal currentPrice;

            var clonedMilk = (Milk)supermarket.GetProduct("Milk");
            clonedMilk.Price = 1;
            sourcePrice = supermarket.GetProduct("Milk").Price;
            currentPrice = clonedMilk.Price;
            Console.WriteLine(String.Format("Source: {0} | Current: {1}", sourcePrice, currentPrice));

            var clonedBread = (Bread)supermarket.GetProduct("Bread");
            clonedBread.Price = 2;
            sourcePrice = supermarket.GetProduct("Bread").Price;
            currentPrice = clonedBread.Price;
            Console.WriteLine(String.Format("Source: {0} | Current: {1}", sourcePrice, currentPrice));

            Console.ReadKey();
        }
    }
}
