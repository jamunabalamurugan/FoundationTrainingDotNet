using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class GuessGame
    {

        string[] result = new string[] { "ATE", "EAT", "ART", "MAT", "MET", "RAT", "SAT", "SET", "RAM", "SAME","STAR", "STARE", "RATE", "MATE", "STEM", "TERM", "EAST", "REST", "TEAR", "MARE", "SEAT", "TEAM", "TRAM", "STREAM", "MATS", "SEAM", "MEAT", "MART", "MASTER" };
        string[] compare = new string[35];
        int score = 0;
        public void displayDetails()
        {
            Console.WriteLine("Welcome to the game of WORD PUZZLE\n");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Create words of three or more letters from the word:\tM A S T E R");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\nInstructions:\n1. Please enter the words in uppercase only. \n2. Every correct word will add 1 point to your score. \n3. In order to quit the game, type 'QUIT'.");

        }
        ~GuessGame()
        {
            result = null;
            compare = null;
            Console.WriteLine("Guess Game Destructor Called");
        }

        static void Main(string[] args)
        {
            bool b = true;
            GuessGame gameobj = new GuessGame();
            gameobj.displayDetails();
            Console.WriteLine("Please enter the words.");
            do
            {

                string sWord;
                sWord = Console.ReadLine();
                bool c = false;
                for (int i = 0; i < gameobj.compare.Length; i++)// To verify that user don't entered any word more than once.
                {
                    if (gameobj.compare[i] == null)
                        break;
                    if (sWord == gameobj.compare[i])
                    {
                        c = true;
                    }
                }

                if (c == true)
                {
                    Console.WriteLine("You have already entered: " + sWord);

                }
                bool d = false;
                foreach (string element in gameobj.result)// validate the word entered by user is in the given array or not.
                {
                    if (sWord.ToUpper() == element)
                    {

                        if (c == false)
                        {
                            gameobj.score++;
                            for (int i = 0; i < gameobj.compare.Length; i++)
                            {

                                if ((gameobj.compare[i] == "" || gameobj.compare[i] == null))
                                {

                                    gameobj.compare[i] = sWord;
                                    Console.WriteLine("Correct");
                                    break;
                                }
                            }
                        }
                        d = true;
                        break;
                    }

                }


                if (sWord == "QUIT") // If user enters quit then show the final result and quit.
                {

                    b = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Your final score is:" + gameobj.score);
                  
                   gameobj = null;
                    GC.Collect();
                    // break;
                    Console.ReadKey();
                    return;
                }
                if (d == false)
                {
                    Console.WriteLine("Incorrect");
                }

            } while (b);
            Console.ReadKey();
        }
        
    }

}
