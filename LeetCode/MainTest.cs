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

        /// <summary>
        /// https://leetcode.com/problems/container-with-most-water/
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea(int[] height)
        {
            int max = 0;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = 0; j < height.Length; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }

                    int tempHeight = height[i] < height[j] ? height[i] : height[j];
                    var tempMax = Math.Abs(i - j) * tempHeight;
                    if (tempMax > max)
                    {
                        max = tempMax;
                    }
                }
            }

            return max;
        }

        [Fact]
        public void Test1()
        {
            int[] array = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int area = MaxArea(array);
            Output.WriteLine(area.ToString());
        }
    }
}
