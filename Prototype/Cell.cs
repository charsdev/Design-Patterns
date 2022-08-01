using System;

namespace Prototype
{
    public class Cell
    {
        private const int mutationMax = 98;
        private readonly Random random = new Random();
        private int _mutationChance;
        private bool _isMutant => _mutationChance > mutationMax;

        public object Clone()
        {
            if (!_isMutant) {
                _mutationChance = random.Next(0, 100);
            }
            return MemberwiseClone();
        }

        public Cell()
        {
            _mutationChance = random.Next(0, 100);
        }

        public override string ToString()
        {
            return _isMutant ? $"is Mutant {_mutationChance} % of mutation" : $"is Normal {_mutationChance} % of mutation";
        }

    }
}
