using System;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode node;
            if (root.val > p.val && root.val > q.val)
            {
                node = LowestCommonAncestor(root.left, p, q);
            }
            else if (root.val < p.val && root.val < q.val)
            {
                node = LowestCommonAncestor(root.right, p, q);
            }
            else
            {
                node = root;
            }

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
                TreeNode node1 = new TreeNode(6);

                TreeNode node21 = new TreeNode(2);
                TreeNode node22 = new TreeNode(8);
                node1.left = node21;
                node1.right = node22;

                TreeNode node31 = new TreeNode(0);
                TreeNode node32 = new TreeNode(4);
                node21.left = node31;
                node21.right = node32;

                TreeNode node33 = new TreeNode(7);
                TreeNode node34 = new TreeNode(9);
                node22.left = node33;
                node22.right = node34;

                TreeNode node43 = new TreeNode(3);
                TreeNode node44 = new TreeNode(5);
                node32.left = node43;
                node32.right = node44;

                LowestCommonAncestor(node1, node21, node22);

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
