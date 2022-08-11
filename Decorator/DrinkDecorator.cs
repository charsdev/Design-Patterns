using System;

namespace Decorator
{

    public abstract class DrinkDecorator : DrinkComponent
    {
        protected readonly DrinkComponent DrinkComponent;

        protected DrinkDecorator(DrinkComponent drinkComponent)
        {
            DrinkComponent = drinkComponent;
        }
    }
}
