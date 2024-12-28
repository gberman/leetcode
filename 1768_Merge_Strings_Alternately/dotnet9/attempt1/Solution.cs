namespace leetcode;
public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int w1 = 0, w2 = 0, totalLetters = word1.Length + word2.Length;
        StringBuilder sb = new (totalLetters);

        while (totalLetters > 0)
        {
            if (w1 < word1.Length)
            {
                sb.Append(word1[w1++]);
                totalLetters--;
            }
            if (w2 < word2.Length)
            {
                sb.Append(word2[w2++]);
                totalLetters--;
            }
        }
        return sb.ToString();
    }
}