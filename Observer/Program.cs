using System;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerNameObserver playerNameObserver = new PlayerNameObserver();

            Player player1 = new Player("Chars");
            Player player2 = new Player("Agave");
            Player player3 = new Player("Yisus");

            player1.Subscribe(playerNameObserver);
            player1.SetName("Carlos");

            player2.Subscribe(playerNameObserver);
            player2.SetName("Agostina");

            player3.Subscribe(playerNameObserver);
            player3.SetName("Jesus");

            EnemyLifeObserver enemyLifeObserver = new EnemyLifeObserver();

            Enemy enemy1 = new Enemy(100);
            Enemy enemy2 = new Enemy(200);
            Enemy enemy3 = new Enemy(300);

            enemy1.Subscribe(enemyLifeObserver);
            enemy2.Subscribe(enemyLifeObserver);
            enemy3.Subscribe(enemyLifeObserver);

            enemy1.ApplyDamage(100);
            enemy2.ApplyDamage(10);
            enemy3.ApplyDamage(22);
        }
    }
}
