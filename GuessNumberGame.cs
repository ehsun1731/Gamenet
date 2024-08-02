using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamesnet
{
    internal class GuessNumberGame:Game
    {
        

        public GuessNumberGame()
        {
            
            _theRandomedNumber = RandomNumGenerator();
           
        }
        private int _theRandomedNumber;
      
        

       
        private int RandomNumGenerator()
        {
            Random rnd = new Random();
            return rnd.Next(0, 101);
        }
        protected override void HowToPlay()
        {
            int counter = 0;
            bool exit=false;
            do
            {
                int GuessedNumber = GetInt("Please enter your guess number (0-100):");
                if (GuessedNumber < _theRandomedNumber)
                {
                    Console.WriteLine("Your Guessed number is less than THE NUMBER");
                    counter++;
                }
                else if (GuessedNumber > _theRandomedNumber)
                {
                    Console.WriteLine("Your Guessed number is more than THE NUMBER");
                    counter++;

                }
                else if (GuessedNumber == _theRandomedNumber)
                {

                    Console.WriteLine($"good job.you did right at step {counter+1} ");

                    exit = true;
                }
            } while (exit == false);

        }
        public int GetInt(string message)
        {
            Console.WriteLine(message);
            int value = int.Parse(Console.ReadLine()!);
            return value;
        }


    }

    }

