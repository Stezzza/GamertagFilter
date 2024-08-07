using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ICTPRG302_Intro_to_Programming
{
    internal class Gamertags
    {
        //list of gamertags from file
        private string[] gamerTagList = { };

        public void LoadGamerTags()
        {
            gamerTagList = File.ReadAllLines("../Gamertags.txt");
        }
        public void PrintAllGamertags()
        {
            Console.Clear();
            Console.WriteLine("========");
            Console.WriteLine("All Gamertags");
            Console.WriteLine("========");

            //loop over list of gamertags and print on each new line
            int lineNumber = 1; //local variable used as a bullet list counter for each line
            foreach (string s in gamerTagList)
            {
                //format a line for each gamertag with a number in front
                Console.WriteLine(lineNumber.ToString() + ") " + s);

                lineNumber = lineNumber + 1; //increment the lineNumber for the next time in the loop
            }

            //dissplay a message to the user and wait for a keypress
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void PrintGamertagsEndingWithNumber()
        {
            Console.Clear();
            Console.WriteLine("========");
            Console.WriteLine("All Gamertags ending with number");
            Console.WriteLine("========");

            //loop over list of gamertags and print on each new line
            int lineNumber = 1; //local variable used as a bullet list counter for each line
            foreach (string s in gamerTagList)
            {
                //test each gamertag to see if it has > 1 character
                // AND if last character is a number
                // if both tests pass then run the if statement
                if ((s.Length > 0) && Char.IsNumber(s, s.Length - 1))
                {
                    //format a line for each gamertag with a number in front
                    Console.WriteLine(lineNumber.ToString() + ") " + s);
                    lineNumber = lineNumber + 1; //increment the lineNumber for the next time in the loop

                }

            }

            //dissplay a message to the user and wait for a keypress
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            
        }
        public void PrintGamertagsNotStartingWithLetterOrNumber()
        {
            Console.Clear();
            Console.WriteLine("========");
            Console.WriteLine("All Gamertags not starting with letter or number");
            Console.WriteLine("========");

            //loop over list of gamertags and print on each new line
            int lineNumber = 1; //local variable used as a bullet list counter for each line
            foreach (string s in gamerTagList)
            {
                //test each gamertag to see if it has > 1 character
                // AND if last character is a number
                // if both tests pass then run the if statement
                if ((s.Length > 0) &! Char.IsLetterOrDigit(s[0]))
                {
                    //format a line for each gamertag with a number in front
                    Console.WriteLine(lineNumber.ToString() + ") " + s);
                    lineNumber = lineNumber + 1; //increment the lineNumber for the next time in the loop

                }

            }

            //dissplay a message to the user and wait for a keypress
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


        }
        public void ShowWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("========");
            Console.WriteLine("Welcome to Gamertag place for Gamertag stuff");
            Console.WriteLine("========");
            Console.WriteLine("What Gamertags would you like to view? a = ALL, b = Ending with number, c = Not starting with letter or numbers");

            ConsoleKey consoleKey = Console.ReadKey().Key;

            if (consoleKey == ConsoleKey.A)
            {
                PrintAllGamertags();
            }
            else if (consoleKey == ConsoleKey.B)
            {
                PrintGamertagsEndingWithNumber();
            }
            else if (consoleKey == ConsoleKey.C)
            {
                PrintGamertagsNotStartingWithLetterOrNumber();
            }
            else
            {
                ShowWelcomeMessage();
            }
        }
    }
}
