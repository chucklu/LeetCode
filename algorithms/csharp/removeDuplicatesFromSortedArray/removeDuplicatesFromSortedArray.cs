public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {

        if (nums == null)
        {
            return 0;
        }
        if (nums.Length == 0)
        {
            return 0;
        }
        if (nums.Length == 1)
        {
            return 1;
        }

        int i = 0;
        int j = i + 1;
        while (j < nums.Length)
        {
            if (nums[i] == nums[j])
            {
                j++;
                if (j >= nums.Length)
                {
                    break;
                }
            }
            else
            {
                i++;
                if (i >= nums.Length)
                {
                    break;
                }
                if (j >= nums.Length)
                {
                    break;
                }
                nums[i] = nums[j];
                j++;
            }
        }

        return i + 1;
    }
}