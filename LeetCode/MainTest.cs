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

    //https://leetcode.com/problems/merge-two-sorted-lists/
    public class Test : BaseTest
    {
        public Test(ITestOutputHelper helper) : base(helper)
        {
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode current1Prev = null;
            ListNode current2Next;
            ListNode head;
            if (l1 == null)
            {
                return l2;
            }

            if (l2 == null)
            {
                return l1;
            }

            ListNode current1;
            ListNode current2;
            if (l1.val <= l2.val)
            {
                current1 = l1;
                current2 = l2;
            }
            else
            {
                current1 = l2;
                current2 = l1;
            }

            head = current1;
            while (current1 != null && current2 != null)
            {
                if (current1.val <= current2.val)
                {
                    current1Prev = current1;
                    current1 = current1.next;
                }
                else
                {
                    current1Prev.next = current2;
                    current2Next = current2.next;
                    current2.next = current1;
                    current2 = current2Next;
                }
            }

            if (current1 == null)
            {
                current1Prev.next = current2;
            }


            return head;
        }

        [Fact]
        public void Test1()
        {
            try
            {
                ListNode lista1 = new ListNode(-9);
                ListNode lista2 = new ListNode(3);
                lista1.next = lista2;

                ListNode listb1 = new ListNode(5);
                ListNode listb2 = new ListNode(7);
                listb1.next = listb2;

                var list = MergeTwoLists(lista1, listb1);
                while (list != null)
                {
                    Output.WriteLine(list.val.ToString());
                    list = list.next;
                }
            }
            catch (Exception ex)
            {
                Output.WriteLine(ex.ToString());
            }
        }
    }
}
