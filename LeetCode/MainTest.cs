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
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(3);
            root.right = new TreeNode(6);
            root.left.left = new TreeNode(2);
            root.left.right = new TreeNode(4);
            root.right.right = new TreeNode(7);
            bool flag = FindTarget(root, 100);
            Assert.True(flag);
        }

        [Fact]
        public void Test2()
        {
            TreeNode root;
            Output.WriteLine($"===second test case===");
            root = new TreeNode(2);
            root.left = new TreeNode(1);
            root.right = new TreeNode(3);
            bool flag = FindTarget(root, 4);
            Assert.True(flag);
        }
    }
}
