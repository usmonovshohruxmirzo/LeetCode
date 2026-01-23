public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {       
            var count = new char[26];
            foreach (char c in str)  count[c - 'a']++;
            var key  = new string(count);
            if (!dict.TryGetValue(key, out var list))
            {
                list = new List<string>();
                dict[key] = list;
            }
            list.Add(str);
        }
        return new List<IList<string>>(dict.Values);
    }
}
