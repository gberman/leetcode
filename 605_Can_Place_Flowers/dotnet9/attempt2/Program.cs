namespace leetcode;
public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (flowerbed.Length == 1 && flowerbed[0] == 0) return --n <= 0;

        for(int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 1) continue;
            if (i == 0)
            {
                if (flowerbed.Length > 2 && flowerbed[i + 1] == 0)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            } 
            else if (i == flowerbed.Length - 1)
            {
                if (flowerbed.Length >= 2 && flowerbed[i-1] == 0)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }
            else if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
            {
                flowerbed[i] = 1;
                n--;
            }
        }
        return n <= 0;
    }
}