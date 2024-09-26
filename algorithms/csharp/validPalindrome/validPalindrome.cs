//https://leetcode.com/problems/valid-palindrome/

public class Solution
{
    public bool IsPalindrome(string s)
    {
        s = s.ToLowerInvariant();
        int i = 0;
        int j = s.Length - 1;
        while (i < j)
        {
            while (i < j && !char.IsLetterOrDigit(s[i]))
            {
                i++;
            }
            while (i < j && !char.IsLetterOrDigit(s[j]))
            {
                j--;
            }
            if (s[i] != s[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}