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

    //https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/
    public class Test : BaseTest
    {
        public Test(ITestOutputHelper helper) : base(helper)
        {
        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            ListNode myHead = new ListNode(head.val + 1);
            myHead.next = head;
            ListNode node1 = myHead;
            ListNode node2 = node1.next;
            ListNode node1Prev = myHead;
            while (node2 != null)
            {
                if (node1.val == node2.val)
                {
                    Remove(node1Prev, node1);
                    node1 = node1Prev.next;
                    node2 = node1?.next;
                }
                else
                {
                    node1Prev = node1;
                    node1 = node2;
                    node2 = node1.next;
                }
            }

            return myHead.next;
        }

        private static void Remove(ListNode nodePrev, ListNode node)
        {
            int val = node.val;
            while (node != null && node.val == val)
            {
                node = node.next;
            }

            nodePrev.next = node;
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
