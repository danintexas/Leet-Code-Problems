/* https://leetcode.com/problems/reverse-integer/
 * 
 * Given a 32-bit signed integer, reverse digits of an integer.
 * 
 * Example 1:
 * Input: 123
 * Output: 321
 * 
 * Example 2:
 * Input: -123
 * Output: -321
 * 
 * Example 3:
 * Input: 120
 * Output: 21
 * 
 * Note:
 * Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. 
 * For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows. 
 */
 
using System;

namespace Leet_Code_Problems
{
    class Reverse_Integer
    {
        public static void LC7()
        {
            Console.WriteLine("Leet Code 7: Reverse Integer => Given a 32-bit signed integer, reverse digits of an integer." + Environment.NewLine);
            Console.Write("Please enter in a numeric value to reverse: ");
            int value = Int32.Parse(Console.ReadLine().ToString());
            Console.WriteLine(Environment.NewLine + "Reversed Value: " + Reverse(value));
            Console.Write(Environment.NewLine + "Press <Enter> to return to main screen.");
            Console.ReadLine();
        }

        public static int Reverse(int x)
        {
            int returnedValue;
            bool isNegative = false;

            if (x < 0)
            {
                isNegative = true;
                x = -x;
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
                returnedValue = Int32.Parse(returnedValueString);
            }
            catch
            {
                return 0;
            }
            

            if (isNegative)
            {
                returnedValue = -returnedValue;
            }

            return returnedValue;
        }
    }
}
