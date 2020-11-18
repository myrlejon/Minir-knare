using System;

namespace Miniräknare
{
    class Program
    {
        static void Main(string[] args)
        {
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

            if (firstOperator == "+" || secondOperator == "+")
            {
                int summa = firstTermInt + secondTermInt + thirdTermInt;
                Console.WriteLine(summa);
                if (summa < 100) {
                    Console.WriteLine("The sum is less than a hundred.");
                }
                else if (summa > 100)
                {
                    Console.WriteLine("The sum is more than a hundred.");
                }
                else if (summa == 100)
                {
                    Console.WriteLine("The sum is exactly one hundred. Clap clap!");
                }
            }
        }
    }
}
