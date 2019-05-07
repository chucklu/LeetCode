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

        public int GetMinimumDifference(TreeNode root)
        {
            int res = int.MaxValue, pre = -1;
            Chuck(root, ref pre, ref res);
            return res;
        }

        private void Chuck(TreeNode node, ref int pre, ref int res)
        {
            if (node == null)
            {
                return;
            }

            Chuck(node.left, ref pre, ref res);
            if (pre != -1)
            {
                res = Math.Min(res, node.val - pre);
            }

            pre = node.val;
            Chuck(node.right, ref pre, ref res);
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
                TreeNode node2 = new TreeNode(3);
                node1.right = node2;
                TreeNode node3 = new TreeNode(2);
                node2.left = node3;
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
