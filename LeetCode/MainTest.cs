using System;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/diameter-of-binary-tree/
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        private int _result;

        public int DiameterOfBinaryTree(TreeNode root)
        {
            Chuck(root);
            return _result;
        }

        private int Chuck(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftDepth = 0;
            int rightDepth = 0;
            if (node.left != null)
            {
                leftDepth = 1 + Chuck(node.left);
            }

            if (node.right != null)
            {
                rightDepth = 1 + Chuck(node.right);
            }

            _result = Math.Max(_result, leftDepth + rightDepth - 1);
            return Math.Max(leftDepth, rightDepth);
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
                TreeNode node1 = new TreeNode(1);
                TreeNode node2 = new TreeNode(2);
                TreeNode node3 = new TreeNode(3);
                TreeNode node4 = new TreeNode(4);
                TreeNode node5 = new TreeNode(5);
                node1.left = node2;
                node2.left = node4;
                node2.right = node5;
                node1.right = node3;

                int result = DiameterOfBinaryTree(node1);
                Output.WriteLine(result.ToString());

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
