namespace DesignPattern.Creational.Factory
{
    class VillagerAbstractFactory : PersonAbstractFactory
    {
        public override IPerson GetPerson()
        {
            return new Villager();
        }
    }
}
