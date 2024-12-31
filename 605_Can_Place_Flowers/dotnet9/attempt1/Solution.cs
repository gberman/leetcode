namespace leetcode;
public class Solution
{
    public (bool Found, int Index) IndexOf(int[] input, int find, int startingPoint)
    {
        for (int i = startingPoint; i < input.Length; i++)
        {
            if (input[i] == find) return (true, i);
        }
        return (false, 0);
    }
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        (bool found, int index) = IndexOf(flowerbed, 1, 0);
        if (found)
        {
            n -= index / 2;
            int startingIndex = index+1;
            
            while(true)
            {
                (found, index) = IndexOf(flowerbed, 1, startingIndex);
                if (found)
                {
                    var l = index - startingIndex;
                    n -= l / 2 + (l % 2 - 1);

                    startingIndex = index+1;
                }
                else { break; }
                
            }
            int ll = flowerbed.Length - startingIndex;
            n -= ll / 2;
        }
        else
        {
            n -= flowerbed.Length / 2 + flowerbed.Length % 2;
        }

        return n <= 0;
    }
}