using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/path-sum-ii/
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        private List<IList<int>> list = new List<IList<int>>();

        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            Chuck(root, sum, 0, null);
            return list;
        }

        private void Chuck(TreeNode node, int sum,int tempSum,List<int> tempList)
        {
            if (node == null)
            {
                return;
            }
            if (tempList == null)
            {
                tempList = new List<int>();
            }

            tempSum = tempSum + node.val;
            var left = node.left;
            var right = node.right;
            tempList.Add(node.val);
            if (left == null && right == null)
            {
                if (tempSum == sum)
                {
                    list.Add(tempList);
                }
            }
            else
            {
                Chuck(left, sum, tempSum, tempList);
                Chuck(right, sum, tempSum, tempList);
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
                TreeNode node1 = new TreeNode(3);
                TreeNode node2 = new TreeNode(9);
                TreeNode node3 = new TreeNode(20);
                node1.left = node2;
                node1.right = node3;

                TreeNode node4 = new TreeNode(15);
                TreeNode node5 = new TreeNode(7);
                node3.left = node4;
                node3.right = node5;
                //int tempSum = SumOfLeftLeaves(node1);
                //Output.WriteLine(tempSum.ToString());
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
