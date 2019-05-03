using System;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/minimum-absolute-difference-in-bst/
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        private int delta = -1;
        public int GetMinimumDifference(TreeNode root)
        {
            Chuck(root);
            return delta;
        }

        private void Chuck(TreeNode node)
        {
            if (delta == 0)
            {
                return;
            }
            if (node == null)
            {
                return;
            }
            var left = node.left;
            var right = node.right;
            int delta1 = -1;
            if (left != null)
            {
                delta1 = node.val - left.val;
            }

            int delta2 = -1;
            if (right != null)
            {
                delta2 = right.val - node.val;
            }

            if (delta1 == -1 && delta2 == -1)
            {
                return;
            }
            else if (delta1 != -1 && delta2 == -1)
            {
                delta = delta1;
            }
            else if (delta1 == -1 && delta2 != -1)
            {
                delta = delta2;
            }
            else
            {
                delta = Math.Min(delta1, delta2);
            }
            Chuck(node.left);
            Chuck(node.right);
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
                node1.right = node2;
                int temp = GetMinimumDifference(node1);
                Output.WriteLine(temp.ToString());
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
