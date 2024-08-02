using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamesnet
{
    internal class GameNet
    {
       


        public void PlayGame(Game game)
        {
           game.Start();
        }
        public void  Menu() 
        {
            var guessNumberGame= new GuessNumberGame();
            var guessWordGame=new GuessWordGame();
            bool exit = false;
            while (exit == false)
            {
                int menu = guessNumberGame.GetInt($"pls choose a game for start:\n" +
                                 $"0-Exit\n" +
                                 $"1-GuessWord Game\n" +
                                 $"2-GuessNumber Game "); 
           
                switch (menu)
                {
                    case 0:
                        exit=true; 
                        break;

                        case 1:
                        {
                           
                            PlayGame(guessWordGame);
                        } break;
                        case 2:
                        {
                            PlayGame(guessNumberGame);
                        
                        }break;

                }
            }

        
        }





    }
}
