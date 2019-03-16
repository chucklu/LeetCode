using System;
using Xunit;
using Xunit.Abstractions;

namespace LeetCode
{

    //https://leetcode.com/problems/same-tree/
    public class Test : BaseTest
    {
        public Test(ITestOutputHelper helper) : base(helper)
        {
        }

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            bool flag;
            if (p == null && q == null)
            {
                flag = true;
            }
            else if (p == null || q == null)
            {
                flag = false;
            }
            else
            {
                if (p.val == q.val)
                {
                    flag = IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
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
