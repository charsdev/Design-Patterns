using System;
using System.Collections.Generic;

namespace State
{

    public abstract class State : IState 
    {
        private readonly IContext _context;

        protected State(IContext context) 
        {
            _context = context;
        }

        public abstract void DoAction();
    }
}
