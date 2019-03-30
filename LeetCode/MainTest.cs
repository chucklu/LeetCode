using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/binary-tree-level-order-traversal/
    public class MainTest : BaseTest
    {
        private readonly List<Tuple<int, int>> _list = new List<Tuple<int, int>>();

        private int _maxDepth;

        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            GetAllNodes(root, 0);
            for (int i = 1; i <= _maxDepth; i++)
            {
                var temp = _list.Where(x => x.Item1 == i).Select(y => y.Item2).ToList();
                result.Add(temp);
            }

            return result;
        }

        private void GetAllNodes(TreeNode node, int depth)
        {
            if (node == null)
                return;
            depth++;
            if (_maxDepth < depth)
            {
                _maxDepth = depth;
            }
            WriteTreeNode(node);
            _list.Add(new Tuple<int, int>(depth, node.val));
            GetAllNodes(node.left, depth);
            GetAllNodes(node.right, depth);
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
                node1.right = node3;

                TreeNode node4 = new TreeNode(4);
                TreeNode node5 = new TreeNode(5);
                node2.left = node4;
                node2.right = node5;

                LevelOrder(node1);

            }
            catch (Exception ex)
            {
                Output.WriteLine(ex.ToString());
            }
        }
    }
}
