using Gamesnet;




var gamenet = new GameNet();
var guessNumber = new GuessNumberGame("guess Number","find the random number between 0 and 100 ");
var guessWord = new GuessWordGame("guess word","second player must guess the word writen by first player");
gamenet.AddGame(guessNumber);
gamenet.AddGame(guessWord);
gamenet.MainMenu();
