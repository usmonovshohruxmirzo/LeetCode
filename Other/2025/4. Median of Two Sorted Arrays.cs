public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] merged = nums1.Concat(nums2).ToArray();
        
        Array.Sort(merged);

        double result = 0;
        
        int n = merged.Length;
        
        result = ((n & 1) == 0)
            ? (merged[n / 2 - 1] + merged[n / 2]) / 2.0
            : merged[n / 2];

        return result;
    }
}
