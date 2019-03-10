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

    //https://leetcode.com/problems/delete-node-in-a-linked-list/
    public class Test : BaseTest
    {
        public Test(ITestOutputHelper helper) : base(helper)
        {
        }

        public void DeleteNode(ListNode node)
        {
            ListNode nodePrev = node;
            while (node.next != null)
            {
                node.val = node.next.val;
                nodePrev = node;
                node = node.next;
            }

            nodePrev.next = null;
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
