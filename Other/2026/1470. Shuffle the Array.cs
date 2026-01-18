public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] x = nums[..n]; 
        int[] y = nums[n..];
        for (int i = 0, j = 0; i < nums.Length; i += 2, j++)
        {
            nums[i] = x[j];
            nums[i + 1] = y[j];
        }
        return nums;
    }
}
