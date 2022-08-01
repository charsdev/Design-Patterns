using System;

namespace Facade
{
    public class ScoreAccumulator
    {
        private int _score;

        public void AddScore()
        {
            _score++;
            Console.WriteLine($"added score {_score}");
        }
    }
}
