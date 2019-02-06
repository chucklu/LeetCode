using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace LeetCode
{
    public class Test:BaseTest
    {
        public Test(ITestOutputHelper helper) : base(helper)
        {
        }

        //https://leetcode.com/problems/valid-palindrome/
        public bool IsPalindrome(string s)
        {
            string temp = "abcdefghijklmnopqrstuvwxyz0123456789";
            s = s.ToLowerInvariant();
            int i = 0;
            int j = s.Length - 1;
            bool result = true;
            while (i < j)
            {
                while (i < j)
                {
                    if (!temp.Contains(s[i]))
                    {
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                while (i < j)
                {
                    if (!temp.Contains(s[j]))
                    {
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
                if (s[i] == s[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        [Fact]
        public void Test1()
        {
            try
            {
                var str = "0P";
                bool flag = IsPalindrome(str);
                Output.WriteLine(flag.ToString());
            }
            catch (Exception ex)
            {
                Output.WriteLine(ex.ToString());
            }
        }
    }
}
