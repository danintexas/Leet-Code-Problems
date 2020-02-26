
namespace Leet_Code_Problems
{
    class Two_Sum_1
    {
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
