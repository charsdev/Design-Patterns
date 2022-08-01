using System;

namespace ChainOfResponsability
{
    public abstract class Handler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual void HandleRequest(int request)
        {
            if (_nextHandler == null)
            {
                Console.WriteLine(request);
                return;
            }

            _nextHandler.HandleRequest(request);
        }
    }   
}
