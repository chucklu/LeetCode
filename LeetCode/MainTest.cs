using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{
    public class Test:BaseTest
    {
        public Test(ITestOutputHelper helper) : base(helper)
        {
        }

        //https://leetcode.com/problems/remove-duplicates-from-sorted-array/
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null)
            {
                return 0;
            }
            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return 1;
            }

            int i = 0;
            int j = i + 1;
            while (j < nums.Length)
            {
                if (nums[i] == nums[j])
                {
                    j++;
                    if (j >= nums.Length)
                    {
                        break;
                    }
                }
                else
                {
                    i++;
                    if (i >= nums.Length)
                    {
                        break;
                    }
                    if (j >= nums.Length)
                    {
                        break;
                    }
                    nums[i] = nums[j];
                    j++;
                }
            }

            return i + 1;
        }
        
        [Fact]
        public void Test1()
        {
            try
            {
                int[] array = {1, 1,};
                var result = RemoveDuplicates(array);
                Output.WriteLine(result.ToString());
            }
            catch (Exception ex)
            {
                Output.WriteLine(ex.ToString());
            }
        }
    }
}
