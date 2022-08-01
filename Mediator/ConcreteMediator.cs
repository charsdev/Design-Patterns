using System;
using System.Collections.Generic;

namespace Mediator
{

    public class ConcreteMediator : IMediator
    {
        private readonly List<Colleague> _colleagues;

        public ConcreteMediator()
        {
            _colleagues = new List<Colleague>();
        }

        public void Notify(string message, Colleague colleague)
        {
            foreach (var item in _colleagues)
            {
                if (item != colleague)
                {
                    item.Receive(message);
                }
            }
        }

        public void Add(Colleague colleague)
        {
            _colleagues.Add(colleague);
        }
    }
}
