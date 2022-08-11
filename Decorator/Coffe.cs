using System;

namespace Decorator
{

    public class Coffe : DrinkComponent
    {
        public override double Cost => 10;
        public override string Description => "Coffe";
    }
}
