using System;

namespace Decorator
{

    public abstract class DecoradorBebida : BebidaComponent
    {
        protected readonly BebidaComponent BebidaComponent;

        protected DecoradorBebida(BebidaComponent bebidaComponent)
        {
            BebidaComponent = bebidaComponent;
        }
    }
}
