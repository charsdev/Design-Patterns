using System;

namespace Decorator
{

    public class Azucar : DecoradorBebida
    {
        public Azucar(BebidaComponent bebidaComponent) : base(bebidaComponent)
        {
        }

        public override double Costo => BebidaComponent.Costo + 2;
        public override string Descripcion => BebidaComponent.Descripcion + ", Azucar";
    }
}
