using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code_Problems
{
    class Launcher : Program
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
                default:
                    Console.WriteLine("Invalid entry.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
