//https://leetcode.com/problems/move-zeroes/

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        if (nums == null)
        {
            return;
        }
        int i = 0;
        int length = nums.Length;
        int counter = 0;
        while (i < length)
        {
            if (nums[i] != 0)
            {
                nums[counter] = nums[i];
                counter++;
            }

            i++;
        }

        while (counter < length)
        {
            nums[counter] = 0;
            counter++;
        }
    }
}