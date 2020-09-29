using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanUI
{
    public class ProgramUI
    {
        //Getting characters of random word
        public void Game()
        {
            Console.WriteLine("Welcome to Hangman! \n" +
                        "Your mystery word is a type of fruit");
            bool keepPlaying = true;
            int livesLeft = 6;
            string[] words = { "apple", "orange", "banana" };
            Random randomWord = new Random();
            var random = randomWord.Next(0, 2);
            char[] letters = words[random].ToCharArray();
            string hiddenWord = String.Concat(letters);

            //Print the word of characters in the random word as "_"

            int wordLength = letters.Length;
            char[] printArray = new char[wordLength];
            int counter = -1;
            foreach (char letter in printArray)
            {
                counter++;
                printArray[counter] = '_';
                Console.WriteLine(printArray[counter]);
            }

            //get the players guess

            while (keepPlaying)
            {
                Console.WriteLine("Guess a letter");
                string playerGuess = Console.ReadLine();
                playerGuess = playerGuess.ToLower();
                char playerChar = Convert.ToChar(playerGuess);

                //Check if players guess matches the array of charcters 
                //If corrcect display character 

                if (letters.Contains(playerChar))
                {
                    foreach (char letter in printArray)
                    {
                        if (letter == playerChar)
                        {
                            printArray[counter] = playerChar;
                        }
                    }
                }
                //If incorrect take away life

                else
                {
                    livesLeft--;
                }
                // If player guesses all letters show victory

                // Display lives left

                if (livesLeft == 6)
                {
                    Console.WriteLine("__________\n" +
                                   "|        |\n" +
                                   "|         \n" +
                                   "|         \n" +
                                   "|         \n" +
                                   "|         ");
                }
                else if (livesLeft == 5)
                {
                    Console.WriteLine("__________\n" +
                                       "|        |\n" +
                                       "|        O\n" +
                                       "|         \n" +
                                       "|         \n" +
                                       "|         \n" +
                                       "5 LIVES LEFT");
                }
                else if (livesLeft == 4)
                {
                    Console.WriteLine("__________\n" +
                                       "|        |\n" +
                                       "|        O\n" +
                                       "|        |\n" +
                                       "|         \n" +
                                       "|         \n" +
                                       "4 LIVES LEFT");
                }
                else if (livesLeft == 3)
                {
                    Console.WriteLine("__________\n" +
                                       "|        |\n" +
                                       "|        O\n" +
                                       "|       /|\n" +
                                       "|         \n" +
                                       "|         \n" +
                                       "3 LIVES LEFT");
                }
                else if (livesLeft == 2)
                {
                    Console.WriteLine("__________\n" +
                                       "|        |\n" +
                                       "|        O\n" +
                                       "|       /|\\ \n" +
                                       "|         \n" +
                                       "|         \n" +
                                       "2 LIVES LEFT");
                }
                else if (livesLeft == 1)
                {
                    Console.WriteLine("__________\n" +
                                       "|        |\n" +
                                       "|        O\n" +
                                       "|       /|\\ \n" +
                                       "|       /  \n" +
                                       "|         \n" +
                                       "1 LIFE LEFT");
                }
                else if (livesLeft == 0)
                {
                    Console.WriteLine("__________\n" +
                                       "|        |\n" +
                                       "|        O\n" +
                                       "|       /|\\ \n" +
                                       "|       / \\n" +
                                       "|         \n" +
                                       "YOU'VE BEEN HANGED!");
                    Console.ReadKey();
                    keepPlaying = false;
                }
            }
        }
    }
}

