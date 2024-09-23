using System;
using System.Text;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                var delta = target - nums[i];
                if (dic.ContainsKey(delta))
                {
                    return new int[] { i, dic[delta] };
                }
                dic[nums[i]] = i;
            }
            return new int[] { };
        }

        [Fact]
        public void Test()
        {
            try
            {
                var nums = new int[] { 2, 7, 11, 15 };
                var target = 9;
                var result = TwoSum(nums, target);
                Output.WriteLine(string.Join(",", result));
            }
            catch (Exception ex)
            {
                Output.WriteLine(ex.ToString());
            }
        }

        [Fact]
        public void Test2()
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
