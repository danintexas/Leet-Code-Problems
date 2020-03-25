using System;

namespace Leet_Code_Problems
{
    class InterviewQuestions
    {
        public static void QuestionOne()
        {
            int[] arr = { 2, 3, 3, 5, 3, 4, 1, 7 };
            int k = arr.Length - 1;

            string arrayValue = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length-1)
                {
                    arrayValue += arr[i];
                }
                else
                {
                    arrayValue = arrayValue + arr[i] + ",";
                }                
            }

            // Iterate though input array, for every element arr[i], increment arr[arr[i]%k] by k 
            for (int i = 0; i < arr.Length; i++)
            {                
                arr[(arr[i] % k)] += k;
            }

            // Find index of the maximum repeating element 
            int max = arr[0], result = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    result = i;
                }
            }

            Console.WriteLine("Array: " + arrayValue);
            Console.WriteLine("Most repeated number: " + result);
            Console.ReadLine();
        }
    }
}
