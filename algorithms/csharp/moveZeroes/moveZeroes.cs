//https://leetcode.com/problems/move-zeroes/

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int nonZero = 0;  // Pointer for non-zero elements

        // Traverse the array
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                // Swap non-zero element with element at nonZero pointer
                int temp = nums[nonZero];
                nums[nonZero] = nums[i];
                nums[i] = temp;
                nonZero++;
            }
        }
    }
}