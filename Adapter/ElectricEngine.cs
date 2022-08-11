using System;

namespace Adapter
{
    public class ElectricEngine
    {
        private bool _connected;
        private bool _active;
        private bool _moving;

        public void Connect()
        {
            if (_connected)
            {
                Console.WriteLine("Cannot connect a engine who was already connected");
            }
            else
            {
                _connected = true;
            }
        }

        public void Activate()
        {
            if (!_active)
            {
                Console.WriteLine("Cannot activate a engine who was already activated");
            }
            else
            {
                _active = true;
            }
        }

        public void Move()
        {
            if (!_connected && !_active)
            {
                Console.WriteLine("The engine need to be connected and active");
            }
            else
            {
                _moving = true;
                Console.WriteLine("Moving a vehicle with a electric engine");
            }
        }

        public void Stop()
        {
            _moving = false;
            Console.WriteLine("The electric engine is stopping");
        }

        public void Disconect()
        {
            _connected = false;
            Console.WriteLine("The engine was disconnected");
        }

        public void Deactivate()
        {
            _active = false;
            Console.WriteLine("the engine was deactivated");
        }

        public void Plug()
        {
            if (!_active)
            {
                _active = false;
                Console.WriteLine("Engine refueling batteries");
            }
            else
            {
                Console.WriteLine("Cannot plug a active engine");
            }
        }
    }
}
