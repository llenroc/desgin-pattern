namespace DesignPattern.Creational.Builder
{
    public class ComputerShop
    {
        public void ConstructComputer(ComputerBuilder computerBuilder)
        {
            computerBuilder.BuildMotherboard();
            computerBuilder.BuildProcessor();
            computerBuilder.BuildHardDisk();
            computerBuilder.BuildScreen();
        }
    }
}
