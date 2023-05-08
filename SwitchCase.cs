﻿using System;

namespace ConsoleApp1
{
    class SwitchCase
    {
        static void Main(string[] args)
        {
            SwitchCase obj = new SwitchCase();
            obj.CalculateProgram();
        }

        private void CalculateProgram()
        {
            int number, i;
            Console.WriteLine("Welcome to calculation program");
            while (true)
            {
                Console.WriteLine("Select number from given options:");
                Console.WriteLine("1 - Fibonacci series");
                Console.WriteLine("2 - Prime number");
                Console.WriteLine("3 - Factoral");
                Console.WriteLine();
                string selectedOption = Console.ReadLine();
                switch (selectedOption)
                {
                    case "1":
                        int n1 = 0, n2 = 1, n3;
                        Console.WriteLine("Fibonacci series program-");
                        Console.Write("Enter the number of elements: ");
                        number = int.Parse(Console.ReadLine());
                        Console.Write(n1 + " " + n2 + " ");
                        for (i = 2; i < number; ++i)
                        {
                            n3 = n1 + n2;
                            Console.Write(n3 + " ");
                            n1 = n2;
                            n2 = n3;
                        }
                        Console.WriteLine();
                        break;

                    case "2":
                        int res, flag = 0;
                        Console.WriteLine("Prime number program-");
                        Console.Write("Enter the Number to check Prime: ");
                        number = int.Parse(Console.ReadLine());
                        res = number / 2;
                        for (i = 2; i <= res; i++)
                        {
                            if (number % i == 0)
                            {
                                Console.WriteLine("Number is not Prime.");
                                flag = 1;
                                break;
                            }
                        }
                        if (flag == 0)
                            Console.WriteLine("Number is Prime.");
                        break;

                    case "3":
                        int fact = 1;
                        Console.WriteLine("Factorial program-");
                        Console.Write("Enter any Number: ");
                        number = int.Parse(Console.ReadLine());
                        for (i = 1; i <= number; i++)
                        {
                            fact = fact * i;
                        }
                        Console.WriteLine("Factorial of " + number + " is: " + fact);
                        break;

                    default:
                        Console.WriteLine("Invalid Number");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to run program again ? (y/n)");
                string runAgain = Convert.ToString(Console.ReadLine());

                if (runAgain == "n")
                {
                    break;
                }
                else if (runAgain != "y")
                {
                    Console.Clear();
                    Console.WriteLine("Invalid selection.");
                    Console.WriteLine("Do you want to run program again ? (y/n)");
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
