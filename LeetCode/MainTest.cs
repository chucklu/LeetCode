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
            Iterate(root);
            return _count;
        }

        private void Iterate(TreeNode node)
        {

            Chuck(node, 0);
            if (node?.left == null && node?.right == null)
            {
                return;
            }
            Iterate(node.left);
            Iterate(node.right);
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
                TreeNode node1 = new TreeNode(1);
                TreeNode node2 = new TreeNode(2);
                node1.right = node2;
                TreeNode node3 = new TreeNode(3);
                node2.right = node3;
                TreeNode node4 = new TreeNode(4);
                node3.right = node4;
                TreeNode node5 = new TreeNode(5);
                node4.right = node5;
                int count = PathSum(node1, 3);
                Output.WriteLine(count.ToString());
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
