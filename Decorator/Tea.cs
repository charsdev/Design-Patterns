using System;

namespace Decorator
{
    public class Tea : DrinkComponent
    {
        public override double Cost => 8;
        public override string Description => "Tea";
    }
}
