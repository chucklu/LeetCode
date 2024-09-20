public class Solution {
    public int[] TwoSum(int[] nums, int target) {
         List<Tuple<int, int>> list = new List<Tuple<int, int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                list.Add(new Tuple<int, int>(i, nums[i]));
            }

            list.Sort((a, b) => a.Item2.CompareTo(b.Item2));
            int headerIndex = 0;
            int tailIndex = nums.Length - 1;
            while (headerIndex < tailIndex)
            {
                if (list[headerIndex].Item2 + list[tailIndex].Item2 == target)
                {
                    break;
                }
                else if (list[headerIndex].Item2 + list[tailIndex].Item2 > target)
                {
                    tailIndex--;
                }
                else
                {
                    headerIndex++;
                }
            }

            int[] result = new int[2];
            result[0] = list[headerIndex].Item1;
            result[1] = list[tailIndex].Item1;
            return result;
    }
}