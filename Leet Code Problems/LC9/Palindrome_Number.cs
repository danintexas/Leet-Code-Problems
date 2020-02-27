/* https://leetcode.com/problems/palindrome-number/
 *  
 * Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.
 * 
 * Example 1:
 * Input: 121
 * Output: true
 * 
 * Example 2:
 * Input: -121
 * Output: false
 * Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
 * 
 * Example 3:
 * Input: 10
 * Output: false
 * Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 */

using System;

namespace Leet_Code_Problems
{
    class Palindrome_Number
    {
        public static void LC9()
        {
            Console.WriteLine("Leet Code 9: Determine whether an integer is a palindrome." + Environment.NewLine);
            Console.Write("Please enter in a numeric value to test: ");
            int value = Int32.Parse(Console.ReadLine().ToString());
            bool valueSubmittedAPalindrome = IsPalindrome(value);

            if (valueSubmittedAPalindrome)
            {
                Console.WriteLine(Environment.NewLine + "The value of : " + value + " is a palindrome number! YEAH!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine(Environment.NewLine + "The value of : " + value + " is not a palindrome number!");
                Console.Write(Environment.NewLine + "Press <Enter> to return to main screen.");
                Console.ReadLine();
            }
        }

        public static bool IsPalindrome(int x)
        {            
            if (x < 0)
            {
                return false;
            }

            char[] reversedValue = x.ToString().ToCharArray();
            Array.Reverse(reversedValue);

            string returnedValueString = "";

            foreach (char character in reversedValue)
            {
                returnedValueString += character;
            }

            try
            {
                if (x == Int32.Parse(returnedValueString))
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
