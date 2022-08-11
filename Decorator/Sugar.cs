using System;

namespace Decorator
{

    public class Sugar : DrinkDecorator
    {
        public Sugar(DrinkComponent bebidaComponent) : base(bebidaComponent)
        {
        }

        public override double Cost => DrinkComponent.Cost + 2;
        public override string Description => DrinkComponent.Description + ", Sugar";
    }
}
