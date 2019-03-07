using System;
using System.Runtime.InteropServices;
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

    //https://leetcode.com/problems/remove-duplicates-from-sorted-list/
    public class Test : BaseTest
    {
        public Test(ITestOutputHelper helper) : base(helper)
        {
        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode node1 = head;
            ListNode node2 = node1?.next;
            while (node2 != null)
            {
                if (node2.val == node1.val)
                {
                    node1.next = node2.next;
                    node2 = node1.next;
                }
                else
                {
                    node1 = node2;
                    node2 = node2.next;
                }
            }

            return head;
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
