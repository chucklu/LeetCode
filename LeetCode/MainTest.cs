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
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();

            IList<int> list = new List<int>();
            IList<IList<int>> result = new List<IList<int>>();

            if (root != null)
            {
                result.Add(list);
                Enqueue(queue, root);
                queue.Enqueue(null);
            }

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node == null)
                {
                    queue.Enqueue(null);
                    if (queue.Peek() == null)
                    {
                        //You are encountering two consecutive `nulls` means, you visited all the nodes.
                        break;
                    }
                    else
                    {
                        list = new List<int>();
                        result.Add(list);
                        continue;
                    }
                }
                else
                {
                    list.Add(node.val);
                }

                Output.WriteLine(node.val.ToString());
                Enqueue(queue, node.left);
                Enqueue(queue, node.right);
            }

            return result;
        }

        private void Enqueue(Queue<TreeNode> tempQueue, TreeNode node)
        {
            if (node != null)
            {
                tempQueue.Enqueue(node);
            }
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

                LevelOrder(node1);

            }
            catch (Exception ex)
            {
                Output.WriteLine(ex.ToString());
            }
        }
    }
}
