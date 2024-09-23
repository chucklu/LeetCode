public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            var delta = target - nums[i];
            if (dic.ContainsKey(delta))
            {
                return new int[] { i, dic[delta] };
            }
            dic[nums[i]] = i;
        }
        return new int[] { };
    }
}