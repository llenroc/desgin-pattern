using System;

namespace DesignPattern.Behavioral.Strategy
{
    public class StrategyProgram
    {
        public static void Work()
        {
            Console.WriteLine("Strategy: ");

            CalculateClient client = new CalculateClient(new Minus());

            Console.WriteLine("Minus: " + client.Calculate(7, 1));

            //Change the strategy
            client.Strategy = new Plus();

            Console.WriteLine("Plus: " + client.Calculate(7, 1));

            Console.WriteLine();
        }
    }
}
