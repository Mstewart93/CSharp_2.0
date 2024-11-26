
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Method_Submission_2
{
    public class Program
    {
        static void Main(string[] args)

        {
            DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45); // show year, month, day, hour, minute, seconds so 8:32 with 45 seconds on may 23 1995
            DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;
            //time stamp on log entry
            //file.Writline(DateTime.Now);
            //File.Writline(Card)

            //the first thing we want to have happen in our game is a welcome message.
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling my your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0} would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower;

            if (answer == "yes" || answer = "yeah" || answer == "y" || answer == "ya")
            { 
            
            Player player = new Player(playerName, bank);
            Game game = new TwentyOneGame();
            game += player;
            player.isActivelyPlaying = true;
            while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();

                }
            game -= player;
                Console.WriteLine("Thank you for playing!");

            }

            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine(); 

        }
    }
}