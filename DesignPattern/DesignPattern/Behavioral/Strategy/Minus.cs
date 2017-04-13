namespace DesignPattern.Behavioral.Strategy
{
    //strategies
    //Strategy 1: Minus
    public class Minus : ICalculate
    {
        public int Calculate(int value1, int value2)
        {
            return value1 - value2;
        }
    }
}
