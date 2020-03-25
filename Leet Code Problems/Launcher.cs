using System;

namespace Leet_Code_Problems
{
    class Launcher
    {        public static void LCLauncher(int choice)
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
                case 14:
                    Console.WriteLine("Starting up the Leet Code 14 test: Longest Common Prefix");
                    Console.ReadLine();
                    Console.Clear();
                    Longest_Common_Prefix.LC14();
                    break;
                case 901:
                    Console.WriteLine("Starting up Interview Question: Maximum repeating element");
                    Console.ReadLine();
                    Console.Clear();
                    InterviewQuestions.QuestionOne();
                    break;
                default:
                    Console.WriteLine("Invalid entry.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
