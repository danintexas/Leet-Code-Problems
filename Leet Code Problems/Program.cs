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
                Console.WriteLine("Please enter in the numeric code of the Leet Code program to execute or 'q' to terminate: ");
                choice = Console.ReadLine();

                if (choice != "q")
                {
                    try
                    {
                        if (Int32.Parse(choice) == 1)
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
                    Console.Clear();
                    Two_Sum_1.LC1();
                    break;
                default:
                    Console.WriteLine("Invalid entry.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}