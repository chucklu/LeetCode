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
                while (nodeA != null || nodeB != null)
                {
                    if (nodeA == nodeB)
                    {
                        resultListNode = nodeA;
                        break;
                    }
                    else
                    {
                        if (nodeA == null)
                        {
                            nodeA = nodeB;
                        }

                        if (nodeB == null)
                        {
                            nodeB = nodeA;
                        }
                        nodeA = nodeA.next;
                        nodeB = nodeB.next;
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
