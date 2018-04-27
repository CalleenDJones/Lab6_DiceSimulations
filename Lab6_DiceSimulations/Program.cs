using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_DiceSimulations
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //1. Number of sides
            //1a. Validate correct type of input
            //2. Roll the dice
            //3. display the results of each dice
            //4. ask if they want to roll again
            //4a. Validate correct type of input

            Game();

        }
        static void Game()
        {
            {
                //Introduction
                Console.WriteLine("Welcome to the Grand Circus Casino-Hotel! ");
                Console.WriteLine("Time to take your chances with Lady Luck!");

                while (true)//Begins loop for Dice Roll
                {
                    //Ask user to participate & respond
                    Console.WriteLine("\nWould you like to roll the dice? Please respond with Y or N.");
                    string PlayTime = Console.ReadLine().ToUpper();

                    //Actions on option provided by user
                    //while (true)
                    {
                        if (PlayTime == "N")
                        {
                            Console.WriteLine("\nThanks for your time. Maybe next time!");
                            Console.WriteLine("\nPlease press enter to exit.");
                            return;//exits program
                        }
                        else if (PlayTime == "Y")
                        {
                            break;//exits section to continue downward through remaining options / questions
                        }
                        else //(PlayTime != "Y" && PlayTime != "N" && PlayTime != "EXIT")
                        {
                            Console.WriteLine("Sorry, that is an invalid response. Please respond with Y, N or Exit.");
                            PlayTime = Console.ReadLine().ToUpper();
                        }
                    }
                }

                while (true)//Begins loop for Number of Sides on dice
                {
                    //Ask user how many sides on each die
                    Console.WriteLine("Thank you! Please enter the number of sides for a pair of dice: ");
                    //if a alpha character is input, the program crashes **need to resolve
                    string Sides = Console.ReadLine();
                    int numberSize;
                    bool check = int.TryParse(Sides, out numberSize);
                    string Response;
                    if (check == false)
                    {
                        Console.WriteLine("Invalid response. Please only enter whole numbers");
                    }

                    //declare variables for Dice Rolls
                    int rolledNum = DiceRoll(numberSize);
                    int rolledNumTwo = DiceRoll(numberSize);

                    Console.WriteLine($"Roll 1:");
                    Console.WriteLine($"------");
                    Console.WriteLine($"{rolledNum}");
                    Console.WriteLine($"{rolledNumTwo}");

                    Console.WriteLine("\n\nFeeling lucky yet? Would you like to play again? Y or N");
                    Response = Console.ReadLine();
                    if (Response != "y")
                        return;
                }
            }
        }

        static int DiceRoll(int numberSides)
        {

            int num = rnd.Next(1, numberSides);
            return num;
        }

    }
}