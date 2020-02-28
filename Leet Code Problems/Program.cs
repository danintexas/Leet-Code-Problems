/*
 * This is just my single project to house all my Leetcode.com work. - Daniel Gail
 */

using System;

namespace Leet_Code_Problems
{
    class Program
    {
        static void Main()
        {
            string choice = "";

            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("Leet Code solution App - By Daniel Gail" + Environment.NewLine);
                Console.WriteLine("1: Two Sum => Given an array of integers, return indices of the two numbers such that they add up to a specific target.");
                Console.WriteLine("7: Reverse Integer => Given a 32-bit signed integer, reverse digits of an integer.");
                Console.WriteLine("9: Determine whether an integer is a palindrome." + Environment.NewLine);
                Console.WriteLine("13: Convert Roman numeral to an Integer." + Environment.NewLine);
                Console.Write("Please enter your selected Leet Code Test or 'q' to quit: ");
                choice = Console.ReadLine();

                if (choice != "q")
                {
                    try
                    {
                        if (Int32.Parse(choice) >= 1)
                        {
                            LCLauncher(Int32.Parse(choice));
                        }

                        else
                        {
                            Console.WriteLine("Not a valid test number!");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }

                    catch
                    {
                        Console.WriteLine("Please enter in a valid numeric value!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                else
                {
                    Console.WriteLine(Environment.NewLine + Environment.NewLine + "Thank you for launching this!");
                    Console.ReadLine();
                }
            }

                     
        }
        public static void LCLauncher(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Starting up the Leet Code 1 test: Two Sums");
                    Console.ReadLine();
                    Console.Clear();
                    Two_Sum.LC1();
                    break;
                case 7:
                    Console.WriteLine("Starting up the Leet Code 7 test: Reverse Integer");
                    Console.ReadLine();
                    Console.Clear();
                    Reverse_Integer.LC7();
                    break;
                case 9:
                    Console.WriteLine("Starting up the Leet Code 9 test: Palindrome Number");
                    Console.ReadLine();
                    Console.Clear();
                    Palindrome_Number.LC13();
                    break;
                case 13:
                    Console.WriteLine("Starting up the Leet Code 13 test: Roman to Integer");
                    Console.ReadLine();
                    Console.Clear();
                    Palindrome_Number.LC13();
                    break;
                default:
                    Console.WriteLine("Invalid entry.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}