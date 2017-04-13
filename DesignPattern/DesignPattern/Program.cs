using DesignPattern.Behavioral.Strategy;
using DesignPattern.Structural.Proxy;
using System;

namespace DesignPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Proxy
            ProxyProgram.Work();

            // Strategy
            StrategyProgram.Work();
        }
    }
}
