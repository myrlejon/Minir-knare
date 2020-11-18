using System;

namespace Miniräknare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Den totala summan av allt som har räknats ihop.
            int totalsum = 0;
            int firstSum = 0;

            //Operatorer, här kan användaren skriva in +, -, *, / osv.
            Console.WriteLine("Enter first operator: ");
            string firstOperator = Console.ReadLine();
            //int firstOperatorInt = Convert.ToInt32(firstOperator);

            Console.WriteLine("Enter second operator: ");
            string secondOperator = Console.ReadLine();
            //int secondOperatorInt = Convert.ToInt32(secondOperator);

            //Termer, här kan användaren skriva in tal.
            Console.WriteLine("Enter first term: ");
            string firstTerm = Console.ReadLine();
            int firstTermInt = Convert.ToInt32(firstTerm);

            Console.WriteLine("Enter second term: ");
            string secondTerm = Console.ReadLine();
            int secondTermInt = Convert.ToInt32(secondTerm);

            Console.WriteLine("Enter third term: ");
            string thirdTerm = Console.ReadLine();
            int thirdTermInt = Convert.ToInt32(thirdTerm);

            if (firstOperator == "+")
            {
                firstSum = firstTermInt + secondTermInt;
            }
            else if (firstOperator == "-")
            {
                firstSum = firstTermInt - secondTermInt;
            }
            if (secondOperator == "+")
            {
                int localsum = 0;
                localsum = firstSum + thirdTermInt;
                Console.WriteLine(localsum);
            }
        }
    }
}
