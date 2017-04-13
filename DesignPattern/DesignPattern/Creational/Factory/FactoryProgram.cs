using System;

namespace DesignPattern.Creational.Factory
{
    class FactoryProgram
    {
        public static void Work()
        {
            Console.WriteLine("Simple factory:");
            var simpleFactory = new PersonFactory();
            var ruralPerson = simpleFactory.GetPerson(PersonType.Rural);
            Console.WriteLine("Rural person : " + ruralPerson.GetName());

            var urbanPerson = simpleFactory.GetPerson(PersonType.Urban);
            Console.WriteLine("Urban person : " + urbanPerson.GetName());

            Console.WriteLine("Abstract factory:");
            var villagerAbstractFactory = new VillagerAbstractFactory();
            ruralPerson = villagerAbstractFactory.GetPerson();
            Console.WriteLine("Rural person : " + ruralPerson.GetName());

            var cityPersonAbstractFactory = new CityPersonAbstractFactory();
            urbanPerson = cityPersonAbstractFactory.GetPerson();
            Console.WriteLine("Urban person : " + urbanPerson.GetName());
        }

    }
}
