using System;
using System.Text;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;
using System.Linq;
using System.Xml.Linq;

namespace LeetCode
{
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        public int RemoveElement(int[] nums, int val)
        {
            int i = 0; // Pointer to place the next non-val element
            int j = nums.Length - 1; // Pointer to the end of the array

            while (i <= j)
            {
                if (nums[i] == val)
                {
                    // Swap the current element with the last element
                    nums[i] = nums[j];
                    j--; // Reduce the end pointer
                }
                else
                {
                    i++; // Move forward if the current element is not val
                }
            }

            return i;
        }

        [Fact]
        public void Test()
        {
            int[] array = { 1 };
            var result = RemoveElement(array, 1);
            Output.WriteLine(result.ToString());
        }

        [Fact]
        public void Test2()
        {
        }
    }
}
