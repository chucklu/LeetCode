using System;
using System.Collections.Generic;
using System.Linq;
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

        private readonly List<int> deltaList = new List<int>();

        private readonly List<int> sourceList = new List<int>();

        public int GetMinimumDifference(TreeNode root)
        {
            Chuck(root);
            int min = deltaList.Min();
            return min;
        }

        private void Chuck(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            int val = node.val;
            if (!sourceList.Contains(val))
            {
                foreach (var item in sourceList)
                {
                    var delta = Math.Abs(item - val);
                    if (!deltaList.Contains(delta))
                    {
                        deltaList.Add(delta);
                    }
                }
                sourceList.Add(val);
            }
            else
            {
                deltaList.Add(0);
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
