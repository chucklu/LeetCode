using System;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/balanced-binary-tree/
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            int maxLeftDepth = MaxDepth(root.left);
            int maxRightDepth = MaxDepth(root.right);
            bool flag1 = Math.Abs(maxLeftDepth - maxRightDepth) <= 1;
            bool flag2 = IsBalanced(root.left);
            bool flag3 = IsBalanced(root.right);
            return flag1 && flag2 && flag3;
        }

        public int MaxDepth(TreeNode root)
        {
            int depth;
            if (root == null)
            {
                depth = 0;
            }
            else
            {
                depth = 1;
                TreeNode left = root.left;
                TreeNode right = root.right;
                if (left != null || right != null)
                {
                    int leftDepth = MaxDepth(left);
                    int rightDepth = MaxDepth(right);
                    depth = depth + Math.Max(leftDepth, rightDepth);
                }
            }

            return depth;
        }

        private void WriteTreeNode(TreeNode node)
        {
            StringBuilder stringBuilder=new StringBuilder();
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
                //node1.left = node2;
                node1.right = node3;

                TreeNode node4 = new TreeNode(15);
                TreeNode node5 = new TreeNode(17);
                node3.left = node4;
                node3.right = node5;

                int minDepth = MinDepth(node1);
                Output.WriteLine(minDepth.ToString());

            }
            catch (Exception ex)
            {
                Output.WriteLine(ex.ToString());
            }
        }
    }
}
