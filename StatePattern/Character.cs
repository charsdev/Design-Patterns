using System;
using System.Collections.Generic;

namespace State
{

    public class Character : IContext
    {
        private IState _currentState;
        private readonly Dictionary<string, State> _states;

        public Character()
        {
            _states = new Dictionary<string, State>();
            _states.Add("Idle", new IdleState(this));
            _states.Add("OnAir", new OnAirState(this));
            _states.Add("Dead", new DeadState(this));
            _currentState = _states["Idle"];
        }

        public void Execute()
        {
            _currentState.DoAction();
        }

        public void TransitionTo(string stateName)
        {
            if (!_states.TryGetValue(stateName, out State state))
            {
                return;
            }

            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            _currentState = state;
        }

        public List<string> GetStates()
        {
            List<string> keys = new List<string>();
            foreach( var key in _states.Keys) 
            {
                keys.Add(key);
            }
            return keys;
        }
    }
}
