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
