using System;

namespace Decorator
{

    public class Leche : DecoradorBebida
    {
        public Leche(BebidaComponent bebidaComponent) : base(bebidaComponent)
        {
        }

        public override double Costo => BebidaComponent.Costo + 3;
        public override string Descripcion => BebidaComponent.Descripcion + ", Leche";
    }
}
