using System;

namespace Decorator
{

    public class Milk : DrinkDecorator
    {
        public Milk(DrinkComponent bebidaComponent) : base(bebidaComponent)
        {
        }

        public override double Cost => DrinkComponent.Cost + 3;
        public override string Description => DrinkComponent.Description + ", Milk";
    }
}
