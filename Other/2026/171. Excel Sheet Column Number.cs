public class Solution {
    public int TitleToNumber(string columnTitle) {
        var value = 0;

        foreach (var ch in columnTitle)
        {
            value *= 26;
            value += ch - 'A' + 1;
        }

        return value;
    }
}
