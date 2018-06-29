using System;

// NameSpace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            //Run fun to get info
            GetAppInfo();
            //Greet user
            GreetUser();


            while (true) {

            
            //Random Number

            Random random = new Random();

            int correctNumber = random.Next(1, 10);


            //Set correct number
            //int correctNumber = 7;

            //Init guess var 
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            while(guess != correctNumber) {
                // Get users number 
                string input = Console.ReadLine();

                //Make sure its a Number
                if (!int.TryParse(input, out guess)) {
                        PrintColor(ConsoleColor.Red, "Please use actual number");
                    
                    continue;
                }

                //Cast to int and put in guess
                guess = Int32.Parse(input);

                //Match guess to correct number
                if(guess != correctNumber){
               
                        PrintColor(ConsoleColor.Red, "Wrong number please try again");
                   
                }

                
            }

                PrintColor(ConsoleColor.Yellow, "You are Correct!!");
             
                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y"){
                    continue;
                }
                if(answer == "N"){
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        static void GetAppInfo(){
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuther = "Clayton Massie";

            //Change text color 
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} By {2}", appName, appVersion, appAuther);

            // Reset text color
            Console.ResetColor();

        }

        static void GreetUser(){
            // Ask user name 
            Console.WriteLine("What is your name?");

            // Get users input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, want to play a game....", inputName);
        }

        //Print cloller massage
        static void PrintColor(ConsoleColor color, string message){
            //Wrong input message
            Console.ForegroundColor = color;

            // Write out app info
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();

        }
    }
}
