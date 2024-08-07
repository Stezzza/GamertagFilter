using System;
using System.IO;

namespace ICTPRG302_Intro_to_Programming
{
	class Program
	{
		/// <summary>
		/// This is the starting location for the program.
		/// </summary>
		/// <param name="args">
		/// A list of strings passed in to the program
		/// from the command-line when it was started
		/// </param>
		static void Main(string[] args)
		{
			bool isRunning = true;

			while (isRunning)
			{
				//Console.WriteLine("*** Program sequence output - display gamertags etc ***");

                Gamertags gamertags = new Gamertags();
                gamertags.LoadGamerTags();
				gamertags.ShowWelcomeMessage();


				//ask the user if we should re-run/exit
				Console.WriteLine("Would you like to view gamertags? y/n");

				//read and compare input to character y
				//keep running if it is y
				if (Console.ReadKey().Key == ConsoleKey.Y)
				{


					isRunning = true;
				}
				else
				{
					isRunning = false;
					break;
				}
				

				

			}
		}
	}
}