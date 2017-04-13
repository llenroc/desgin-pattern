using System;

namespace DesignPattern.Creational.Singleton
{
    class SingletonProgram
    {
        public static void Work()
        {
            Console.WriteLine("Singleton: ");

            ConfigurationManager.GetInstance.DisplayConfiguration();

            Console.WriteLine();
        }
    }
}
