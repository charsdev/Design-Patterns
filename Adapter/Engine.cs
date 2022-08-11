using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public abstract class Engine
    {
        public abstract void Accelerate();
        public abstract void Stop();
        public abstract void Start();
        public abstract void Refuel();
    }
}
