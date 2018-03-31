using System;

namespace The_Guessing_Number_Game
{
     // Main class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run get app info 

            GreatUser(); // Ask for user name and great 
            while (true)
            {

                // Set correct number 
                //  int CorrectNumber = 7;

                // create a new random object
                Random random = new Random();
                int CorrectNumber = random.Next(1, 10);

                // int gues var 
                int guess = 0;

                //Asking user for number
                Console.WriteLine("Guess a number between 1 and 10 ");

                // input not correct
                while (guess != CorrectNumber)
                {
                    string input = Console.ReadLine();

                    //Make sure input is a number 

                    if (!int.TryParse(input, out guess))
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number ");

                        //keep going 
                        continue;



                    }

                    //cast to int and put in guess 
                    guess = Int32.Parse(input);

                    // match guess to correct number 
                    if (guess != CorrectNumber)
                    {
                      // print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, Please try again");
                    }

                }

                // output sucess message 
                PrintColorMessage(ConsoleColor.Yellow, "Correct you guessed it");

                // Ask user to play again
                Console.WriteLine("Play again ? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else {
                    return;
                }
            }



        }
        static void GetAppInfo()
        {
            // Setting up app 
            string appName = "The Guessing Number ";
            string appVersion = "1.0.1";
            string appAuthor = "Jessie Gonzalez";

            // Changing text color 
            Console.ForegroundColor = ConsoleColor.Blue;


            // Description 
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Resetting text color
            Console.ResetColor();
        }
        static void GreatUser ()
        {
            //Ask users name 
            Console.WriteLine("What is your name ?");

            // user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game...", inputName);

        }
        // print color message
        static void PrintColorMessage(ConsoleColor color, string message) {
            // Tell user its not a numer 
            Console.ForegroundColor = color;


            // Description 
            Console.WriteLine(message);

            //Resetting text color
            Console.ResetColor();
        }
    }
}
