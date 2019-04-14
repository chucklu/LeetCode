using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/binary-tree-paths/
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        private List<string> list = new List<string>();
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            else
            {
                Chuck(string.Empty, root);
            }

            return list;
        }

        private void Chuck(string str,TreeNode node)
        {
            if (node == null)
            {
                if (!string.IsNullOrEmpty(str))
                {
                    list.Add(str);
                }
            }
            else
            {
                str = $"{str}-->{node.val}";
                Chuck(str, node.left);
                Chuck(str,node.right);
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
                TreeNode node1 = new TreeNode(1);
                TreeNode node2 = new TreeNode(2);
                TreeNode node3 = new TreeNode(3);
                node1.left = node2;
                node1.right = node3;

                TreeNode node4 = new TreeNode(5);
                node2.right = node4;

                var tempList = BinaryTreePaths(node1);
                foreach (var item in tempList)
                {
                    Output.WriteLine(item);
                }
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
