namespace leetcode;
public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int max = candies[0];
        for (int i = 1; i < candies.Length; i++)
            max = max > candies[i] ? max : candies[i];

        bool[] result = new bool[candies.Length];
        for (int i = 0; i < candies.Length; i++)
            result[i] = extraCandies + candies[i] >= max;

        return result;
    }
}