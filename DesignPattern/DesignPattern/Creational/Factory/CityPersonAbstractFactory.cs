namespace DesignPattern.Creational.Factory
{
    class CityPersonAbstractFactory : PersonAbstractFactory
    {
        public override IPerson GetPerson()
        {
            return new CityPerson();
        }
    }
}
