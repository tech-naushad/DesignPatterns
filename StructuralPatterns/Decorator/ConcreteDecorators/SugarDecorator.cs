namespace StructuralPatterns.Decorator.ConcreteDecorators
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {

        }
        public override string GetDescription()
        {
            return base.GetDescription() + " with sugger";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 0.5;
        }
    }
}
