using System;
using System.Text;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;
using System.Linq;

namespace LeetCode
{
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        public bool FindTarget(TreeNode root, int k)
        {
            List<int> list = new List<int>();
            InOrderTraversal(root, list);

            int i = 0;
            int j = list.Count - 1;
            while (i < j)
            {
                int sum = list[i] + list[j];
                if (sum == k)
                {
                    return true;
                }
                if (sum > k)
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

        private void InOrderTraversal(TreeNode node, List<int> list)
        {
            if (node == null)
            {
                return;
            }

            // In-order traversal: Left, Root, Right
            InOrderTraversal(node.left, list);
            list.Add(node.val);
            InOrderTraversal(node.right, list);
        }

        [Fact]
        public void Test()
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
                Assert.True(flag);

                root = new TreeNode(2);
                root.left = new TreeNode(1);
                root.right = new TreeNode(3);
                flag = FindTarget(root, 4);
                Assert.True(flag);

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
