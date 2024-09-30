﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using NUnit.Framework;
using System.Data.SqlTypes;

namespace LeetCode
{
    [TestFixture]
    public class MainTest
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;
            ListNode next = head?.next;
            while (current != null)
            {
                Console.WriteLine($"before reverse: prev = {prev?.val}, current = {current.val}, next = {next?.val}");
                current.next = prev;   // Reverse the link
                prev = current;        // Move prev one step ahead
                current = next;        // Move current one step ahead
                next = current?.next;   // Save the next node  
                ListNodeHelper.PrintList(prev);
            }
            Console.WriteLine($"before reverse: prev = {prev?.val}, current = {current?.val}, next = {next?.val}");
            return prev;
        }

        public ListNode ReverseList2(ListNode head)
        {
            ListNode newHead = null;
            while (head != null)
            {
                var next = head.next;
                head.next = newHead;
                newHead = head;
                head = next; 
                ListNodeHelper.PrintList(newHead);
            }
            return newHead;
        }

        public ListNode ReverseList3(ListNode head)
        {
            var next = head?.next;
            if (head == null || next == null)
            {
                return head;
            }
            var temp = ReverseList3(next);
            Console.WriteLine($"head = {head.val}, next = {next.val}");
            next.next = head;
            head.next = null;
            Console.WriteLine($"temp = {temp.val}");
            return temp;
        }

        [Test]
        public void Test()
        {
            // Creating the nodes
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(4);

            // Linking the nodes
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;

            // Head of the list points to node1
            ListNode head = node1;

            ListNodeHelper.PrintList(head);

            var reverseList = ReverseList3(head);
            ListNodeHelper.PrintList(reverseList);
        }



        [Test]
        public void Test2()
        {
        }
    }
}
