using System;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/convert-bst-to-greater-tree/
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        public TreeNode ConvertBST(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            int sum = 0;
            Chuck(root, ref sum);
            return root;
        }

        private void Chuck(TreeNode node, ref int sum)
        {
            if (node == null)
            {
                return;
            }

            Chuck(node.right, ref sum);
            sum = sum + node.val;
            node.val = sum;
            Chuck(node.left, ref sum);
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
                TreeNode node2 = new TreeNode(2);
                TreeNode node3 = new TreeNode(13);
                node1.left = node2;
                node1.right = node3;
                var result = ConvertBST(node1);
                WriteTreeNode(result);
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
