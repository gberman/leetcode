namespace leetcode;
public class Solution {
    public static bool RepeatedMatch(string input, ref ReadOnlySpan<char> match)
    {
        if (input.Length % match.Length != 0) return false;

        int times = (input.Length / match.Length) - 1;

        while (times >= 0)
        {
            ReadOnlySpan<char> substring = input.AsSpan(times * match.Length, match.Length);
            if (!substring.SequenceEqual(match))
                return false;
            times--;
        }
        
        return true;
    }
    public static bool RepeatedMatch(string input, string match)
    {
        ReadOnlySpan<char> matchWrapper = match.AsSpan();
        return RepeatedMatch(input, ref matchWrapper);
    }
    public string GcdOfStrings(string str1, string str2) {
        int l1 = str1.Length;
        int l2 = str2.Length;

        if (l1 == l2 && str1 != str2) return "";
        
        string shorter = l1 >= l2 ? str2 : str1;
        string longer = l1 < l2 ? str2 : str1;

        int size = shorter.Length;
        string possibleMatch = shorter;
        while (size > 0){
            
            if (shorter.Length % size != 0 || longer.Length % size != 0)
            {
                size--;
                continue;
            }

            var tMatch = shorter.AsSpan(0, size);
            if (Solution.RepeatedMatch(shorter, ref tMatch) && 
                Solution.RepeatedMatch(longer, ref tMatch))
                return tMatch.ToString();

            size--;
        }
        return "";
    }
}