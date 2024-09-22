using System;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/diameter-of-binary-tree/
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dic.Add(i, nums[i]);
            }
            for(int i = 0; i < nums.Length; i++)
            {
                var delta = target - nums[i];
                if (dic.ContainsValues(delta))
                {
                    for(int j = 0; j++; j < nums.Length)
                    {
                        if (delta == dic[j])
                        {
                            return new int[] { i, j };
                        }
                    }
                }
            }
            return new int[] { };
        }

        [Fact]
        public void Test()
        {
            try
            {

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
