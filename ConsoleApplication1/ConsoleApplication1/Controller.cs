using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Controller
    {
        private Board Game;
        private Player P1, P2;
        public Controller()
        {
            this.Game = new Board(3, 4, 6);
            this.P1 = new Player("Minh");
            this.P2 = new Player("Duc");
        }
        public void PlayGame()
        {
            Game.PrintGame();
            while (true)
            {
                P1.PickBall(Game);
                Console.WriteLine(P1.GetName() + "plays...");
                Game.PrintGame();
                if(Game.IsGameOver())
                {
                    Console.WriteLine("P1 Game Over");
                    break;
                }
                P2.PickBall(Game);
                Console.WriteLine(P2.GetName() + "plays...");
                Game.PrintGame();
                if(Game.IsGameOver())
                {
                    Console.WriteLine("P2 Game Over ");
                    break;
                }
            }
            

        }
    }
}
