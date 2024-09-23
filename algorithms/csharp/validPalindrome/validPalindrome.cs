using System.Text.RegularExpressions;
public class Solution
{
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
}