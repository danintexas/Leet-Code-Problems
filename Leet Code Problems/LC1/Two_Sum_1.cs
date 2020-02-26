using System;

namespace Leet_Code_Problems
{
    class Two_Sum_1
    {
        public static void LC1()
        {
            // Variables Needed
            int[] twoSumNums = { 1, 2, 5, 6, 7 };
            int twoSumTarget = 6;
            int[] response = Two_Sum_1.TwoSum(twoSumNums, twoSumTarget);
            string sentArray = "";
            string responseArray = "[ " + response[0].ToString() + "," + response[1].ToString() + " ]";

            // Build out the arrays into Strings
            for (int x = 0; x < twoSumNums.Length; x++)
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

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] returnValue = new int[2];

            for (int first = 0; first < nums.Length; first++)
            {
                for (int second = first + 1; second < nums.Length; second++)
                {
                    int sum = nums[first] + nums[second];
                    if (sum == target)
                    {
                        returnValue[0] = first;
                        returnValue[1] = second;
                    }
                }
            }

            return returnValue;
        }


    }
    
}
