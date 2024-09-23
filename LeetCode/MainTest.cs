using System;
using System.Text;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;
using System.Linq;

namespace LeetCode
{
    public class MainTest : BaseTest
    {
        public MainTest(ITestOutputHelper helper) : base(helper)
        {
        }

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
        public void Test()
        {
            try
            {
                var str = "A man, a plan, a canal: Panama";
                var result = IsPalindrome(str);
                Output.WriteLine($"result = {result}");
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
