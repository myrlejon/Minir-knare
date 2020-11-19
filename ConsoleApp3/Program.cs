using System;
using System.Collections.Generic;
using System.Linq;

namespace Miniräknare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Den totala summan av allt som har räknats ihop.
            int firstSum = 0;
            int localsum = 0;

            // En lista där alla värden kommer sparas för den slutgiltiga uträkningen.
            List<int> totalSum = new List<int>();

            bool quit = false;

            while (quit == false)
            {

                // Operatorer, här kan användaren skriva in +, -, *, /, %
                Console.WriteLine("Enter first operator: ");
                string firstOperator = Console.ReadLine();

                Console.WriteLine("Enter second operator: ");
                string secondOperator = Console.ReadLine();

                // Termer, här kan användaren skriva in tal.
                Console.WriteLine("Enter first term: ");
                string firstTerm = Console.ReadLine();
                int firstTermInt = Convert.ToInt32(firstTerm);

                Console.WriteLine("Enter second term: ");
                string secondTerm = Console.ReadLine();
                int secondTermInt = Convert.ToInt32(secondTerm);

                Console.WriteLine("Enter third term: ");
                string thirdTerm = Console.ReadLine();
                int thirdTermInt = Convert.ToInt32(thirdTerm);


                // Detta kodblocket räknar ut de två summorna till vänster först, eftersom det är så man gör när man räknar med tre termer. Ex. (x + x) - x
                if (firstOperator == "+")
                {
                    firstSum = firstTermInt + secondTermInt;
                }
                else if (firstOperator == "-")
                {
                    firstSum = firstTermInt - secondTermInt;
                }
                else if (firstOperator == "*")
                {
                    firstSum = firstTermInt * secondTermInt;
                }
                else if (firstOperator == "/")
                {
                    firstSum = firstTermInt / secondTermInt;
                }
                else if (firstOperator == "%")
                {
                    firstSum = firstTermInt % secondTermInt;
                }

                // Detta kodblocket jobbar tillsammans med det förgående.
                if (secondOperator == "+")
                {
                    localsum = firstSum + thirdTermInt;
                    totalSum.Add(localsum);
                    Console.WriteLine(firstTermInt + " " + firstOperator + " " + secondTermInt + " " + secondOperator + " " + thirdTermInt + " = " + localsum);
                }
                if (secondOperator == "-")
                {
                    localsum = firstSum - thirdTermInt;
                    totalSum.Add(localsum);
                    Console.WriteLine(firstTermInt + " " + firstOperator + " " + secondTermInt + " " + secondOperator + " " + thirdTermInt + " = " + localsum);
                }
                if (secondOperator == "*")
                {
                    localsum = firstSum * thirdTermInt;
                    totalSum.Add(localsum);
                    Console.WriteLine(firstTermInt + " " + firstOperator + " " + secondTermInt + " " + secondOperator + " " + thirdTermInt + " = " + localsum);

                }
                if (secondOperator == "/")
                {
                    localsum = firstSum / thirdTermInt;
                    totalSum.Add(localsum);
                    Console.WriteLine(firstTermInt + " " + firstOperator + " " + secondTermInt + " " + secondOperator + " " + thirdTermInt + " = " + localsum);
                }
                if (secondOperator == "%")
                {
                    localsum = firstSum % thirdTermInt;
                    totalSum.Add(localsum);
                    Console.WriteLine(firstTermInt + " " + firstOperator + " " + secondTermInt + " " + secondOperator + " " + thirdTermInt + " = " + localsum);
                }

                // Här så skrivs det ifall uträkningen var mer, mindre eller lika med 100.
                if (localsum < 100)
                {
                    Console.WriteLine("Less than a hundred.");
                }
                else if (localsum > 100)
                {
                    Console.WriteLine("More than a hundred.");
                }
                else if (localsum == 100)
                {
                    Console.WriteLine("Exactly one hundred.");
                }


                Console.WriteLine("Do you want to continue? Y/N");
                string decision = Console.ReadLine();
                if (decision == "N")
                {
                    quit = true;
                    int totalSumEnd = totalSum.Sum();
                    Console.WriteLine("The total sum of everything you have calculated: " + (string.Join(" + ", totalSum)) + " = " + totalSumEnd);
                    Console.WriteLine("Enter any key to close the application.");
                    Console.ReadLine();
                }
                

            }

        }
    }
}