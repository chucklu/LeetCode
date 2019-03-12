using System;
using System.Runtime.InteropServices;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/middle-of-the-linked-list/
    public class Test : BaseTest
    {
        public Test(ITestOutputHelper helper) : base(helper)
        {
        }

        public ListNode MiddleNode(ListNode head)
        {
            var slow = head;
            var fast = head;
            // Get the middle of the list.
            // Move slow by 1 and fast by 2
            // slow will have the middle mode
            while (fast?.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            return slow;
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
