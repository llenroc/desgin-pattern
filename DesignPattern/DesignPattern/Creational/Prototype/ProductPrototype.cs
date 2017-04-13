namespace DesignPattern.Creational.Prototype
{
    public abstract class ProductPrototype
    {
        public decimal Price { get; set; }

        public ProductPrototype(decimal price)
        {
            Price = price;
        }

        public abstract ProductPrototype Clone();
    }
}
