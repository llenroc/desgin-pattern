using System;

namespace DesignPattern.Structural.Proxy
{
    public class ProxyProgram
    {
        // How to use above Proxy class?
        public static void Work()
        {
            Console.WriteLine("Proxy: ");

            ICar car = new ProxyCar(new Driver(16));
            car.DriveCar();

            car = new ProxyCar(new Driver(25));
            car.DriveCar();

            Console.WriteLine();
        }
    }
}
