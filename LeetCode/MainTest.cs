using System;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/path-sum-iii/
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        private int _count;
        private int _target;

        public int PathSum(TreeNode root, int sum)
        {
            _target = sum;
            Chuck(root, 0);
            Chuck(root?.left, 0);
            Chuck(root?.right, 0);
            return _count;
        }

        private void Chuck(TreeNode node, int sum)
        {
            if (node == null)
            {
                return;
            }

            sum = sum + node.val;
            if (sum == _target)
            {
                _count++;
            }
            if (node.left == null && node.right == null)
            {
                return;
            }
            Chuck(node.left, sum);
            Chuck(node.right, sum);
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
