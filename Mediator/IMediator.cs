using System;
using System.Collections.Generic;

namespace Mediator
{

    public interface IMediator
    {
        void Notify(string message, Colleague colleague);
    }
}
