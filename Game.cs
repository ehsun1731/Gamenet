using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamesnet
{
    public abstract class Game
    {
        public Game(string name, string description )
        {
            _name= name;
            _description = description;
        }
        

        private string _name;
        private string _description;
        public abstract string Name { get;  }
        public abstract string Description { get;  }

        protected abstract void HowToPlay();

        public void Start()
        {
            Console.WriteLine("the game started");
            HowToPlay();

        }


        public static int GetInt(string message)
        {
            Console.WriteLine(message);
            int value = int.Parse(Console.ReadLine()!);
            return value;
        }
        public static char GetChar(string message)
        {
            Console.WriteLine(message);
            char value = char.Parse(Console.ReadLine()!);
            return value;

        }
        public static string GetString(string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine()!;
            return value;

        }
    }
}
