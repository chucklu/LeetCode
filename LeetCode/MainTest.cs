using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/find-mode-in-binary-search-tree/
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        private readonly Dictionary<int, int> dictionary = new Dictionary<int, int>();

        public int[] FindMode(TreeNode root)
        {
            Chuck(root);
            if (dictionary.Count > 0)
            {
                int max = dictionary.Max(x => x.Value);
                var array = dictionary.Where(x => x.Value == max).Select(x => x.Key).ToArray();
                return array;
            }
            else
            {
                return new int[0];
            }
        }

        private void Chuck(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            int val = node.val;
            if (dictionary.ContainsKey(val))
            {
                dictionary[val]++;
            }
            else
            {
                dictionary[val] = 1;
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
                TreeNode node3 = new TreeNode(2);
                node2.left = node3;
                var array = FindMode(node1);
                string str = string.Join(",", array);
                Output.WriteLine(str);
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
