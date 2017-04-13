using System;

namespace DesignPattern.Structural.Proxy
{
    //Proxy Object
    public class ProxyCar : ICar
    {
        private readonly Driver Driver;
        private readonly ICar RealCar;

        public ProxyCar(Driver driver)
        {
            this.Driver = driver;
            this.RealCar = new Car();
        }

        public void DriveCar()
        {
            if (Driver.Age <= 16)
                Console.WriteLine("Sorry, the driver is too young to drive.");
            else
                this.RealCar.DriveCar();
        }
    }
}
