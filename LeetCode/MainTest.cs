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

        private int pre = -1;

        private int res = int.MaxValue;

        public int GetMinimumDifference(TreeNode root)
        {
            Chuck(root);
            return res;
        }

        private void Chuck(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Chuck(node.left);
            Output.WriteLine($"prev = {pre}");
            if (pre != -1)
            {
                int delta = node.val - pre;
                Output.WriteLine($"{node.val} - {pre} = {delta}");
                res = Math.Min(res, delta);
            }

            pre = node.val;
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
                TreeNode node1 = new TreeNode(5);
                TreeNode node2 = new TreeNode(4);
                TreeNode node3 = new TreeNode(7);
                node1.left = node2;
                node1.right = node3;
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
                TreeNode node1 = new TreeNode(236);
                TreeNode node2 = new TreeNode(104);
                TreeNode node3 = new TreeNode(701);
                node1.left = node2;
                node1.right = node3;

                TreeNode node4 = new TreeNode(227);
                node2.right = node4;
                TreeNode node5 = new TreeNode(911);
                node3.right = node5;

                int temp = GetMinimumDifference(node1);
                Output.WriteLine(temp.ToString());
            }
            catch (Exception ex)
            {
                Output.WriteLine(ex.ToString());
            }
        }
    }
}
