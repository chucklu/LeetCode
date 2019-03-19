using System;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/maximum-depth-of-binary-tree/
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

        public int MaxDepth(TreeNode root)
        {
            int depth;
            if (root == null)
            {
                depth = 0;
            }
            else
            {
                depth = 1;
                TreeNode left = root.left;
                TreeNode right = root.right;
                if (left != null || right != null)
                {
                    int leftDepth = MaxDepth(left);
                    int rightDepth = MaxDepth(right);
                    depth = depth + Math.Max(leftDepth, rightDepth);
                }
            }

            return depth;
        }

        [Fact]
        public void Test()
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
