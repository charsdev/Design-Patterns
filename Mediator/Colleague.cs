using System;
using System.Collections.Generic;

namespace Mediator
{

    public abstract class Colleague
    {
        public IMediator Mediator { get; protected set; }

        protected Colleague(IMediator mediator)
        {
            Mediator = mediator;
        }

        public void Communicate(string message)
        {
            Mediator.Notify(message, this);
        }

        public abstract void Receive(string message);
    }
}
