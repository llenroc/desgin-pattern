namespace DesignPattern.Structural.Proxy
{
    class MainProgram
    {
        // How to use above Proxy class?
        public void Main()
        {
            ICar car = new ProxyCar(new Driver(16));
            car.DriveCar();

            car = new ProxyCar(new Driver(25));
            car.DriveCar();
        }
    }
}
