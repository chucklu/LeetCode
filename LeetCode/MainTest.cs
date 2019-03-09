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

    //https://leetcode.com/problems/remove-linked-list-elements/
    public class Test : BaseTest
    {
        public Test(ITestOutputHelper helper) : base(helper)
        {
        }

        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode myHead = new ListNode(0);
            myHead.next = head;
            ListNode current = head;
            ListNode currentPrev = myHead;
            while (current != null)
            {
                if (current.val == val)
                {
                    current = current.next;
                    currentPrev.next = current;
                }
                else
                {
                    currentPrev = current;
                    current = current.next;
                }
            }

            return myHead.next;
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
