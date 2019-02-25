using System;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }

    //https://leetcode.com/problems/move-zeroes/
    public class Test : BaseTest
    {
        public Test(ITestOutputHelper helper) : base(helper)
        {
        }

        public void MoveZeroes(int[] nums)
        {
            if (nums == null)
            {
                return;
            }
            int i = 0;
            int length = nums.Length - 1;
            int counter = 0;
            while (i < length)
            {
                if (nums[i] != 0)
                {
                    nums[counter] = nums[i];
                    counter++;
                }

                i++;
            }

            while (counter < length)
            {
                nums[counter] = 0;
                counter++;
            }
        }

        [Fact]
        public void Test1()
        {
            try
            {
            }
            catch (Exception ex)
            {
                Output.WriteLine(ex.ToString());
            }
        }
    }
}
