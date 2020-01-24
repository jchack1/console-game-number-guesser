using System;

//Namespace
namespace NumberGuesser
{
    //main class
    class Program
    {
        //entry point method
        //void is return type, won't return anything
        static void Main(string[] args)
        {
            GetAppInfo(); //display game info to console 

            GreetUser(); //take user name, greet them

            while (true)
            {
                //Init correct number
                //int correctNumber = 7;

                //random number
                System.Random random = new System.Random();
                int correctNumber = random.Next(1, 10);


                //Init guess var
                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //get user input
                    string input = Console.ReadLine();

                    //make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number");

                        continue;
                    }

                    //cast to int and put in guess variable, make sure it is integer
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                //output success message

                PrintColorMessage(ConsoleColor.Green, "You are correct! Yay!!");

                //ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

            
        }

        static void GetAppInfo()
            {
                //Set app vars

                string appName = "Number Guesser";
                string appVersion = "1.0.0";
                string appAuthor = "Julia";

                //Change text color
                Console.ForegroundColor = ConsoleColor.Cyan;

                //Write out app info
                Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

                //Reset text color
                Console.ResetColor();
            }

        static void GreetUser()
        {
            //Ask user for name
            Console.WriteLine("What is your name?");

            //get user input
            string nameInput = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", nameInput);

        }

        //print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            //Write out app info
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}
