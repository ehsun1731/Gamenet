using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Gamesnet
{
    internal class GuessWordGame:Game
    { 
        


        protected override void HowToPlay() 
        {
            string word = GetString("first player enter the word");
            char[] splitedWord = word.ToCharArray();
            int counter = 0;
            Console.WriteLine($"the word has {splitedWord.Length} characters\n" +
                              $" so you can guess '{splitedWord.Length}' times   ");
                                


            while (counter < splitedWord.Length*splitedWord.Length)
            {

                for (int i = 0; i < splitedWord.Length; i++)
                 Console.Write("_" + " "); 
                char guessedChar = GetChar("second player guss the character");
                for(int i = 0; i < splitedWord.Length; i++)
                {

                    if (splitedWord[i] == guessedChar)
                    {
                        Console.WriteLine($"the character '{guessedChar}' is character number {i+1} of the word  ");
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine($"the character '{guessedChar}' is Not character number {i + 1} of the word ");
                        counter++;
                    }

                }
                

            }
            Console.WriteLine($"the word was {word} ");

        }
       protected char GetChar(string message)
        {
            Console.WriteLine(message);
            char value=char.Parse(Console.ReadLine()!);
            return value;

        }
       protected  string GetString(string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine()!;
            return value;

        }

    }
}
