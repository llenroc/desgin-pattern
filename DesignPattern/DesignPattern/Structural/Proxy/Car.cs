using System;

namespace DesignPattern.Structural.Proxy
{
    // Real Object
    public class Car : ICar
    {
        public void DriveCar()
        {
            Console.WriteLine("Car has been driven!");
        }
    }
}
