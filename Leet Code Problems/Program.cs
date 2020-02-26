using System;

namespace Leet_Code_Problems
{
    class Program
    {
        static void Main()
        {
            // Variables Needed
            int[] twoSumNums = { 1, 2, 5, 6, 7 };
            int twoSumTarget = 6;
            int[] response = Two_Sum_1.TwoSum(twoSumNums, twoSumTarget);
            string sentArray = "";
            string responseArray = "[ " + response[0].ToString() + "," + response[1].ToString() + " ]";

            // Build out the arrays into Strings
            for(int x = 0; x < twoSumNums.Length; x++)
            {
                if (x == 0)
                {
                    sentArray = "[ " + twoSumNums[x].ToString() + ",";
                }

                else if (x == twoSumNums.Length - 1)
                {
                    sentArray = sentArray + twoSumNums[x].ToString() + " ]";
                }

                else
                {
                    sentArray = sentArray + twoSumNums[x].ToString() + ",";
                }
            }

            Console.WriteLine("Leet Code 1: Two Sum" + Environment.NewLine + "     Given an array of integers, return indices of the two numbers such" + 
                " that they add up to a specific target." + Environment.NewLine + Environment.NewLine + "Values sent to method: " + sentArray + Environment.NewLine + 
                "Target Value: " + twoSumTarget + Environment.NewLine + "Response from method: " + responseArray);
            Console.ReadLine();
        }
    }
}