public class Solution {
    public int MaxArea(int[] height) {
          int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;
            while (left < right)
            {
                int width = right - left;
                int tempheight = Math.Min(height[left],height[right]);
                int tempMaxArea = width * tempheight;
                maxArea = Math.Max(maxArea, tempMaxArea);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
    }
}