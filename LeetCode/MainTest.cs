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

        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int uniqueCount = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[uniqueCount - 1] != nums[i])
                {
                    nums[uniqueCount] = nums[i];
                    uniqueCount++;
                }
            }

            return uniqueCount;
        }

        [Fact]
        public void Test()
        {
            int[] array = { 1, 1, 2 };
            var result = RemoveDuplicates(array);
            Output.WriteLine(result.ToString());
        }

        [Fact]
        public void Test2()
        {
        }
    }
}
