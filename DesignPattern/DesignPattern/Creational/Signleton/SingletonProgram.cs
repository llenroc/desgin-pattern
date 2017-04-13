using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Signleton
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
