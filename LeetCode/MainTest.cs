using System;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{
    public class Test:BaseTest
    {
        public Test(ITestOutputHelper helper) : base(helper)
        {
        }

        //https://leetcode.com/problems/remove-element/
        public int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            int j = nums.Length - 1;
            while (i <= j)
            {
                if (nums[i] != val)
                {
                    i++;
                }
                else
                {
                    //in this case,i is not added
                    //in next loop, it will check value nums[j], which was set to nums[i]
                    nums[i] = nums[j];
                    j--;
                }
            }

            return j + 1;
        }

        [Fact]
        public void Test1()
        {
            try
            {
                int[] array = { 1};
                var result = RemoveElement(array,1);
                Output.WriteLine(result.ToString());
            }
            catch (Exception ex)
            {
                Output.WriteLine(ex.ToString());
            }
        }
    }
}
