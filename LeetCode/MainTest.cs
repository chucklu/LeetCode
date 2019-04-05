using System;
using System.Text;
using Xunit;
using Xunit.Abstractions;

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
                int[] array = new[] {-10, -3, 0, 5, 9};
                TreeNode root = SortedArrayToBST(array);
                WriteTreeNode(root);
            }
            catch (Exception ex)
            {
                Output.WriteLine(ex.ToString());
            }
        }
    }
}
