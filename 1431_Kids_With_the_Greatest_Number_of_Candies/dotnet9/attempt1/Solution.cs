namespace leetcode;
public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int max = candies.Max();
        return candies.Select(x => (x + extraCandies) >= max).ToList();
    }
}