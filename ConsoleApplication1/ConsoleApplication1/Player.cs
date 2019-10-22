using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Player
    {
        private string Name;
        public void PickBall(Board game)
        {
            Console.Write("which group you want to choose ? ");
            int group = int.Parse(Console.ReadLine());
            Console.Write("How many balls do you choose in this ground? ");
            int balls = int.Parse(Console.ReadLine());
            game.PickBall(group, balls);
        }
        public  Player(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return this.Name;
        }

    }
}
