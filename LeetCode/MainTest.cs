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
            var pattern = "[a-z0-9]+";
            s = s.ToLowerInvariant();
            Regex regex = new Regex(pattern);
            var array = regex.Matches(s).Cast<Match>().Select(x => x.Value).ToArray();
            s = string.Join(string.Empty, array);
            int i = 0;
            int j = s.Length - 1;
            bool result = true;
            while (i < j)
            {
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
                var str = "A man, a plan, a canal: Panama";
                IsPalindrome(str);
            }
            catch (Exception ex)
            {
                Output.WriteLine(ex.ToString());
            }
        }
    }
}
