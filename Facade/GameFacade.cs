namespace Facade
{
    public class GameFacade
    {
        private readonly GameStarter _gameStarter;
        private readonly ScoreAccumulator _scoreAccumulator;

        public GameFacade()
        {
            _scoreAccumulator = new ScoreAccumulator();
            _gameStarter = new GameStarter();
        }

        public void AddScore()
        {
            _scoreAccumulator.AddScore();
        }

        public void StartGame()
        {
            _gameStarter.StartGame();
        }

    }
}
