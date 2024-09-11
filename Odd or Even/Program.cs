using System;

namespace Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserValue;
            while (true) 
            {
                UserValue = GetInput("Please enter a number between -10000 and 100000");
                if (UserValue > 100000 && UserValue < -10000) 
                {
                    Console.WriteLine("The Value you have given is out of range, please try again.");
                }
                else if (UserValue <= 100000 && UserValue >= -10000)
                {
                    string response = OddEven(UserValue);
                    Console.WriteLine($"your number is {response}");
                    break;
                }
            }

        }
        static int GetInput(string inputMessage)
        {
            var rawInput = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine($"{inputMessage}");
                    rawInput = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You have given an invalid input");
                }
            }
            return rawInput;
        }

        static string OddEven(int numInput)
        {
            string oddResponse = "";

            int oddCheck = numInput % 2;
            if (oddCheck == 1)
            {
                oddResponse = "Odd";
            }
            else if (oddCheck == 0)
            {
                oddResponse = "Even";
            }

            return oddResponse;
        }
    }
}
