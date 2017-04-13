using DesignPattern.Behavioral.Strategy;
using DesignPattern.Creational.Builder;
using DesignPattern.Creational.Factory;
using DesignPattern.Creational.Signleton;
using DesignPattern.Structural.Proxy;
using System;

namespace DesignPattern
{
    static class Program
    {
        enum DesignPatternType
        {
            Factory,
            Builder,
            Singleton,
            Proxy,
            Strategy
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please select a design pattern:");

            foreach (var item in Enum.GetValues(typeof(DesignPatternType)))
            {
                Console.WriteLine((int)item + ": " + item.ToString());
            }
            Console.Write("You select number :");

            var number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case (int)DesignPatternType.Factory:
                    FactoryProgram.Work();
                    break;
                case (int)DesignPatternType.Builder:
                    BuilderProgram.Work();
                    break;
                case (int)DesignPatternType.Singleton:
                    SingletonProgram.Work();
                    break;
                case (int)DesignPatternType.Proxy:
                    ProxyProgram.Work();
                    break;
                case (int)DesignPatternType.Strategy:
                    StrategyProgram.Work();
                    break;
                default:
                    Console.Write("Not support!");
                    break;
            }
        }
    }
}
