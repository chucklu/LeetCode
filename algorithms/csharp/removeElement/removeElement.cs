//https://leetcode.com/problems/remove-element/

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int i = 0;
        int j = nums.Length - 1;
        while (i <= j)
        {
            if (nums[i] != val)
            {
                i++;
            }
            else
            {
                //in this case,i is not added
                //in next loop, it will check value nums[j], which was set to nums[i]
                nums[i] = nums[j];
                j--;
            }
        }

        return j + 1;
    }
}