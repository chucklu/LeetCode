using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }

    public class Test:BaseTest
    {
        public Test(ITestOutputHelper helper) : base(helper)
        {
        }

        //https://leetcode.com/problems/two-sum-iv-input-is-a-bst/
        public bool FindTarget(TreeNode root, int k)
        {
            List<int> list = new List<int>();
            IterateBinaryTree(root, list);
            list.Sort();
            var array = list.ToArray();

            int i = 0;
            int j = array.Length - 1;
            while (i < j)
            {
                if (array[i] + array[j] == k)
                {
                    return true;
                }
                if (array[i] + array[j] > k)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return false;
        }

        private static void IterateBinaryTree(TreeNode node, List<int> list)
        {
            if (node == null)
            {
                return;
            }

            list.Add(node.val);

            if (node.left != null)
            {
                IterateBinaryTree(node.left, list);
            }
            if (node.right != null)
            {
                IterateBinaryTree(node.right, list);
            }
        }

        [Fact]
        public void Test1()
        {
            try
            {
                TreeNode root = new TreeNode(5);
                root.left = new TreeNode(3);
                root.right = new TreeNode(6);
                root.left.left = new TreeNode(2);
                root.left.right = new TreeNode(4);
                root.right.right = new TreeNode(7);
                bool flag = FindTarget(root, 9);
                Output.WriteLine(flag.ToString());

                root = new TreeNode(2);
                root.left = new TreeNode(1);
                root.right = new TreeNode(3);
                flag = FindTarget(root, 4);
                Output.WriteLine(flag.ToString());
            }
            catch (Exception ex)
            {
                Output.WriteLine(ex.ToString());
            }
        }
    }
}
