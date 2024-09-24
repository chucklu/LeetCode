using System;
using System.Text;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;
using System.Linq;
using System.Xml.Linq;

namespace LeetCode
{
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        public bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> set = new HashSet<int>();
            return Find(root, k, set);
        }

        private bool Find(TreeNode node, int k , HashSet<int> set)
        {
            if (node == null)
            {
                return false;
            }
            Output.WriteLine($"node = {node.val}, node.left = {node.left?.val}, node.right = {node.right?.val},");
            var delta = k - node.val;
            if (set.Contains(delta))
            {
                return true;
            }
            set.Add(node.val);
            return Find(node.left, k, set) || Find(node.right, k, set);
        }

        [Fact]
        public void Test()
        {
            Output.WriteLine($"===first test case===");
            var node1 = new TreeNode(1);

            var node2 = new TreeNode(2, node1);
            var node4 = new TreeNode(4);
            var node7 = new TreeNode(7);

            var node3 = new TreeNode(3, node2, node4);
            var node6 = new TreeNode(6, null, node7);

            var node5 = new TreeNode(5, node3, node6);
            bool flag = FindTarget(node5, 13);
            Assert.True(flag);
        }

        [Fact]
        public void Test2()
        {
            Output.WriteLine($"===second test case===");
            var node1 = new TreeNode(1);
            var node3 = new TreeNode(3);

            var node2 = new TreeNode(2, node1, node3);
            bool flag = FindTarget(node2, 4);
            Assert.True(flag);
        }
    }
}
