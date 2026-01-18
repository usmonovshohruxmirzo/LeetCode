public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        char[] sSort = s.ToCharArray();
        char[] tSort = t.ToCharArray();
        Array.Sort(sSort);
        Array.Sort(tSort);
        return sSort.SequenceEqual(tSort);
    }
}
