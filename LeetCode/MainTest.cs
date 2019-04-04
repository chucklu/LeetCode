using System;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace LeetCode
{

    //https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBST(nums, 0, nums.Length - 1);
        }

        public TreeNode SortedArrayToBST(int[] arr, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            int mid = (start + end) / 2;
            TreeNode node = new TreeNode(arr[mid]);
            node.left = SortedArrayToBST(arr, start, mid - 1);
            node.right = SortedArrayToBST(arr, mid + 1, end);
            return node;
        }

        private void WriteTreeNode(TreeNode node)
        {
            if (node == null)
            {
                Console.WriteLine("node is null");
                return;
            }
            Console.Write($"node is {node.val}");
            if (node.left == null)
            {
                Console.Write(", node.left is null");
            }
            else
            {
                Console.Write($", node.left is {node.left.val}");
            }
            if (node.right == null)
            {
                Console.WriteLine(", node.right is null");
            }
            else
            {
                Console.WriteLine($", node.right is {node.right.val}");
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
                //node1.right = node3;

                TreeNode node4 = new TreeNode(4);
                TreeNode node5 = new TreeNode(5);
                node2.left = node4;
                node2.right = node5;

                LevelOrderBottom(node1);

            }
            catch (Exception ex)
            {
                Output.WriteLine(ex.ToString());
            }
        }
    }
}
