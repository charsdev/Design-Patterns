using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class ElectricEngineAdapter : Engine
    {
        private readonly ElectricEngine _engine = new ElectricEngine();

        public override void Accelerate()
        {
            _engine.Move();
        }

        public override void Start()
        {
            _engine.Connect();
            _engine.Activate();
        }

        public override void Refuel()
        {
            _engine.Plug();
        }

        public override void Stop()
        {
            _engine.Deactivate();
            _engine.Stop();
        }
    }
}
