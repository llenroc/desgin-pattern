using System;

namespace DesignPattern.Creational.Singleton
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private static object syncRoot = new object();
        private ConfigurationManager()
        {
        }
        public static ConfigurationManager GetInstance
        {
            get
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new ConfigurationManager();
                    }
                }
                return instance;
            }
        }
        public void DisplayConfiguration()
        {
            Console.WriteLine("Single instance object");
        }
    }
}
