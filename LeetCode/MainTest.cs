using System;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/intersection-of-two-linked-lists/
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode resultListNode = null;
            if (headA == null || headB == null)
            {
            }
            else
            {
                var nodeA = headA;
                var nodeB = headB;
                while (true)
                {
                    if (nodeA == nodeB)
                    {
                        resultListNode = nodeA;
                        break;
                    }
                    else
                    {
                        nodeA = nodeA.next;
                        nodeB = nodeB.next;
                        if (nodeA == null)
                        {
                            nodeA = headB;
                        }

                        if (nodeB == null)
                        {
                            nodeB = headA;
                        }
                    }
                }
            }

            return resultListNode;
        }

        private void WriteTreeNode(TreeNode node)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (node == null)
            {
                Output.WriteLine("node is null");
                return;
            }

            stringBuilder.Append($"node is {node.val}");
            if (node.left == null)
            {
                stringBuilder.Append(", node.left is null");
            }
            else
            {
                stringBuilder.Append($", node.left is {node.left.val}");
            }
            if (node.right == null)
            {
                stringBuilder.Append(", node.right is null");
            }
            else
            {
                stringBuilder.Append($", node.right is {node.right.val}");
            }
            Output.WriteLine(stringBuilder.ToString());

            if (node.left != null)
            {
                WriteTreeNode(node.left);
            }
            if (node.right != null)
            {
                WriteTreeNode(node.right);
            }
        }

        [Fact]
        public void Test()
        {
            try
            {
                ListNode node1 = new ListNode(4);
                ListNode node2 = new ListNode(1);
                node1.next = node2;
                ListNode node3 = new ListNode(8);
                node2.next = node3;
                ListNode node4 = new ListNode(4);
                node3.next = node4;
                ListNode node5 = new ListNode(5);
                node4.next = node5;

                ListNode node6 = new ListNode(5);
                ListNode node7 = new ListNode(0);
                node6.next = node7;
                ListNode node8 = new ListNode(1);
                node7.next = node8;
                node8.next = node3;

                var resultNode = GetIntersectionNode(node1, node6);
                Output.WriteLine(resultNode.val.ToString());
            }
            catch (Exception ex)
            {
                Output.WriteLine(ex.ToString());
            }
        }

        [Fact]
        public void Test2()
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
