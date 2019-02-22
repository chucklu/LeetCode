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
            next = null;
        }
    }

    //https://leetcode.com/problems/reverse-linked-list/
    public class Test : BaseTest
    {
        public Test(ITestOutputHelper helper) : base(helper)
        {
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode current = head;
            ListNode next = current?.next;
            if (next != null)
            {
                head.next = null;
            }
            while (next != null)
            {
                ListNode next2 = next.next;
                next.next = current;

                current = next;
                next = next2;
            }

            return current;
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
