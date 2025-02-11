﻿namespace BasicCalculatorAssignment
{
    internal class Program
    {
        // The goal of this assignment is to learn how to create and use methods in our code
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an operation: ");

                // Task 1. Read choice input and assing it to new int variable
                int choice = int.Parse(Console.ReadLine()!);

                // Task 2. Check if user selected choice 5. If so then exit the loop
                if (choice == 5) break;

                Console.Write("Enter first number: ");
                // Task 3. Get the first number and assing it to new double variable
                double lhs = double.Parse(Console.ReadLine()!);

                Console.Write("Enter second number: ");
                // Task 4. Get the second number and assing it to new double variable
                double rhs = double.Parse(Console.ReadLine()!);

                // Task 5. Create double variable for default result value and assign it to be 0
                double res = 0.0;

                // Task 6. Handle choices using switch statement
                // Task 6.1 For each case create new function/method an call it inside the case
                //          - Case 1: Add 
                //          - Case 2: Subtract
                //          - Case 3: Multiply
                //          - Case 4: Divide, Note remeber to handle 0
                // Note: Think what the default choice should be
                // Note: Declare each case function/method outside Main method
                //       There is comment below where you can place your methods

                switch (choice)
                {
                    case 1:
                        res = Add(lhs, rhs);
                        break;
                    case 2:
                        res = Subtract(lhs, rhs);
                        break;
                    case 3:
                        res = Multiply(lhs, rhs);
                        break;
                    case 4:
                        if (rhs != 0.0)
                        {
                            res = Divide(lhs, rhs);
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero, try again");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        continue;
                }

                // Task 7. Print out the result
                Console.WriteLine($"The result is: {res}");
            }
        }

        // Declare your methods/functions here
        static double Add(double lhs, double rhs)
        {
            return lhs + rhs;
        }

        static double Subtract(double lhs, double rhs)
        {
            return lhs - rhs;
        }

        static double Multiply(double lhs, double rhs)
        {
            return lhs * rhs;
        }

        static double Divide(double lhs, double rhs)
        {
            return lhs / rhs;
        }
    }
}