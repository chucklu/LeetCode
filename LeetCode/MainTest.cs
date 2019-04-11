using System;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/invert-binary-tree/
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            var left = root.left;
            var right = root.right;
            if (left == null && right == null)
            {
                return root;
            }

            if (left != null)
            {
                root.right = InvertTree(left);
            }

            if (right != null)
            {
                root.left = InvertTree(right);
            }

            return root;
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
                TreeNode node1 = new TreeNode(5);
                TreeNode node2 = new TreeNode(4);
                TreeNode node3 = new TreeNode(8);
                node1.left = node2;
                node1.right = node3;

                TreeNode node4 = new TreeNode(11);
                TreeNode node5 = new TreeNode(13);
                TreeNode node6 = new TreeNode(4);
                node2.left = node4;
                node3.left = node5;
                node3.right = node6;


                TreeNode node7 = new TreeNode(7);
                TreeNode node8 = new TreeNode(2);
                TreeNode node9 = new TreeNode(1);
                node4.left = node7;
                node4.right = node8;
                node6.right = node9;

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
