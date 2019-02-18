using System;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{
    //https://leetcode.com/problems/merge-sorted-array/
    //https://www.geeksforgeeks.org/merge-two-sorted-arrays/
    public class Test:BaseTest
    {
        public Test(ITestOutputHelper helper) : base(helper)
        {
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }

                k--;
            }

            while (i >= 0)
            {
                nums1[k] = nums1[i];
                k--;
                i--;
            }
            while (j >= 0)
            {
                nums1[k] = nums2[j];
                k--;
                j--;
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
