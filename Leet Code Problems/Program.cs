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
                Console.WriteLine("Easy Leet Code Problems" + Environment.NewLine);
                Console.WriteLine(" 1: Two Sum:               Given an array of integers, return indices of the two numbers such that they add"+ 
                    Environment.NewLine + "                                up to a specific target.");
                Console.WriteLine(" 7: Reverse Integer:       Given a 32-bit signed integer, reverse digits of an integer.");
                Console.WriteLine(" 9: Palindrome Number:     Determine whether an integer is a palindrome.");
                Console.WriteLine("13: Roman to Integer:      Convert Roman numeral to an Integer.");
                Console.WriteLine("14: Longest Common Prefix: Longest common prefix string amongst an array of strings.");
                Console.Write(Environment.NewLine + "Please enter your selected Leet Code Test or 'q' to quit: ");
                choice = Console.ReadLine();

                if (choice != "q")
                {
                    try
                    {
                        if (Int32.Parse(choice) >= 1)
                        {
                            Launcher.LCLauncher(Int32.Parse(choice));
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
                    Console.WriteLine(Environment.NewLine + "Thank you for launching this!");
                    Console.ReadLine();
                }
            }                     
        }
    }
}