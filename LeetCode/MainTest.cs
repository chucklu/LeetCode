using System;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/symmetric-tree/
    public class Test : BaseTest
    {
        public Test(ITestOutputHelper helper) : base(helper)
        {
        }

        public bool IsSymmetric(TreeNode root)
        {
            return IsMirror(root?.left, root?.right);
        }

        public bool IsMirror(TreeNode left, TreeNode right)
        {
            bool flag;
            if (left == null && right == null)
            {
                flag = true;
            }
            else if (left == null || right == null)
            {
                flag = false;
            }
            else
            {
                if (left.val == right.val)
                {
                    flag = IsMirror(left.left, right.right) && IsMirror(left.right, right.left);
                }
                else
                {
                    flag = false;
                }
            }

            return flag;
        }

        [Fact]
        public void Test1()
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
