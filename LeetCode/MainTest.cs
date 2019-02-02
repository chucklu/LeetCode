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
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;
            while (left < right)
            {
                int width = right - left;
                int tempheight = Math.Min(height[left],height[right]);
                int tempMaxArea = width * tempheight;
                maxArea = Math.Max(maxArea, tempMaxArea);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }

        [Fact]
        public void Test1()
        {
            try
            {
                int[] array = {1, 8, 6, 2, 5, 4, 8, 3, 7};
                int area = MaxArea(array);
                Output.WriteLine(area.ToString());

                array = new int[] { 3, 1, 2, 4, 5 };
                area = MaxArea(array);
                Output.WriteLine(area.ToString());

                array = new int[] { 1, 5, 4, 3 };
                area = MaxArea(array);
                Output.WriteLine(area.ToString());

            }
            catch (Exception ex)
            {
                Output.WriteLine(ex.ToString());
            }
        }
    }
}
