using System;

namespace Decorator
{
    public abstract class DrinkComponent
    {
        public abstract double Cost { get; }
        public abstract string Description { get; }
    }
}
