using System;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/sum-of-left-leaves/
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        private int sum;

        public int SumOfLeftLeaves(TreeNode root)
        {
            Chuck(root.right, false);
            return sum;
        }

        private void Chuck(TreeNode node, bool isLeft)
        {
            if (node.left == null && node.right == null)//leaf node
            {
                if (isLeft)
                {
                    sum = sum + node.val;
                }
            }
            else
            {
                Chuck(node.left, true);
                Chuck(node.right, false);
            }
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
                TreeNode node1 = new TreeNode(3);
                TreeNode node2 = new TreeNode(9);
                TreeNode node3 = new TreeNode(20);
                node1.left = node2;
                node1.right = node3;

                TreeNode node4 = new TreeNode(15);
                TreeNode node5 = new TreeNode(7);
                node3.left = node4;
                node3.right = node5;
                int tempSum = SumOfLeftLeaves(node1);
                Output.WriteLine(tempSum.ToString());
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
