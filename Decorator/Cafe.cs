using System;

namespace Decorator
{

    public class Cafe : BebidaComponent
    {
        public override double Costo => 10;
        public override string Descripcion => "Cafe";
    }
}
