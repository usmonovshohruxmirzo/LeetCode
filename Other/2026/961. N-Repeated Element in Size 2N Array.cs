public class Solution {
    public int RepeatedNTimes(int[] nums) {
        HashSet<int> set = new();
   
        foreach (int n in nums) {
            if (!set.Add(n))
            {
                return n;
            } 
        }
   
        return -1;
    }
}
