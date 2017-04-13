using DesignPattern.Behavioral.Strategy;
using DesignPattern.Creational.Signleton;
using DesignPattern.Structural.Proxy;

namespace DesignPattern
{
    static class Program
    {
        static void Main(string[] args)
        { 
            // Singleton
            SingletonProgram.Work();

            // Proxy
            ProxyProgram.Work();

            // Strategy
            StrategyProgram.Work();
        }
    }
}
