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

    //https://leetcode.com/problems/reverse-string/
    public class Test : BaseTest
    {
        public Test(ITestOutputHelper helper) : base(helper)
        {
        }
        public void ReverseString(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                var temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                i++;
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
