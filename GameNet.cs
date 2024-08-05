using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamesnet
{
    internal class GameNet
    {

        public List<Game> _game = new();
        public void AddGame(Game game) 
        {
        _game.Add(game);
        }

       
        public void MainMenu()
        {

            bool exit = false;
            while (exit == false)
            {
                int menu = Game.GetInt($"pls choose a game for start:\n" +
                                 $"0-Exit\n" +
                                 $"1-Games\n" +
                                 $"2-Games with description ");

                switch (menu)
                {
                    case 0:
                        exit = true;
                        break;

                    case 1:
                        

                            GamesList();

                        
                        break;
                    case 2:
                        GamesListWithDescription();

                        break;

                    default:
                        Console.WriteLine("pls choose a currect option ");
                        break;
                }
            }


        }
        private void PlayGame(Game game)
        {
            game.Start();
        }
        private void GamesList()
        {
            bool backToMainMenu = false;

            while (!backToMainMenu)
            {
                Console.WriteLine("0 - Back to Main Menu");
                for (int i = 0; i < _game.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {_game[i].Name}");
                }
                

                int chooseGame = Game.GetInt("Please choose a game to start");

                if (chooseGame == 0)
                {
                    backToMainMenu = true;
                }
                else if (chooseGame >= 1 && chooseGame <= _game.Count)
                {
                    PlayGame(_game[chooseGame - 1]);
                }
                else
                {
                    Console.WriteLine("Invalid game selection");
                }
            }
        }
        private void GamesListWithDescription()
        {
            bool backToMainMenu = false;

            while (!backToMainMenu)
            {
                Console.WriteLine("0 - Back to Main Menu");
                for (int i = 0; i < _game.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {_game[i].Name} ->description: {_game[i].Description}");
                }


                int chooseGame = Game.GetInt("Please choose a game to start");

                if (chooseGame == 0)
                {
                    backToMainMenu = true;
                }
                else if (chooseGame >= 1 && chooseGame <= _game.Count)
                {
                    PlayGame(_game[chooseGame - 1]);
                }
                else
                {
                    Console.WriteLine("Invalid game selection");
                }
            }
        }






    }
}
