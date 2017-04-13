using System;

namespace DesignPattern.Creational.Builder
{
    class BuilderProgram
    {
        public static void Work()
        {
            Console.WriteLine("Builder: ");
            ComputerShop computerShop = new ComputerShop();
            ComputerBuilder computerBuilder;

            computerBuilder = new LaptopBuilder();
            computerShop.ConstructComputer(computerBuilder);
            computerBuilder.Computer.DisplayConfiguration();

            computerBuilder = new DesktopBuilder();
            computerShop.ConstructComputer(computerBuilder);
            computerBuilder.Computer.DisplayConfiguration();

            computerBuilder = new AppleBuilder();
            computerShop.ConstructComputer(computerBuilder);
            computerBuilder.Computer.DisplayConfiguration();
            Console.WriteLine();
        }
    }
}
