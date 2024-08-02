using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamesnet
{
    public abstract class Game
    {

        

        protected abstract void HowToPlay();

        public void Start()
        {
            Console.WriteLine("the game started");
            HowToPlay();

        }
    }
}
