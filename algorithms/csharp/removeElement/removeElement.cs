//https://leetcode.com/problems/remove-element/

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int i = 0; // Pointer to place the next non-val element
        int j = nums.Length - 1; // Pointer to the end of the array

        while (i <= j)
        {
            if (nums[i] == val)
            {
                // Swap the current element with the last element
                nums[i] = nums[j];
                j--; // Reduce the end pointer
            }
            else
            {
                i++; // Move forward if the current element is not val
            }
        }

        return i;
    }
}