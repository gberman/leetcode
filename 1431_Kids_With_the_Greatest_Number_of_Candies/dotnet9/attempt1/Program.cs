global using System;
global using System.Collections.Generic;
global using System.Collections;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;

using leetcode;

string PrintList<T>(IList<T> bools)
{
    StringBuilder sb = new StringBuilder(bools.Count() * 7 + 2);
    sb.Append("[");
    foreach (var v in bools)
    {
        sb.Append(v);
        sb.Append(',');
    }
    sb.Append("]");

    return sb.ToString();
}

string PrintArray<T>(T[] bools) => PrintList<T>(bools.ToList());
bool Matches(bool[] expected, IList<bool> actual)
{
    for(int i = 0; i < expected.Length; i++)
    {
        if (expected[i] != actual[i]) return false;
    }
    return true;
}

string PrintTests(Input input, bool[] expected)
{
    Solution solution = new();
    var processed = solution.KidsWithCandies(input.candies, input.extraCandies);
    string status = expected == processed ? "success" : "failure";
    return $"[{status}] Kid will have the max number of candies: '{PrintArray(input.candies)}' when given an extra: {input.extraCandies} ==> '{PrintList(processed)}'";
}

Console.WriteLine(PrintTests(new Input([2,3,5,1,3], 3), [true,true,true,false,true]));
Console.WriteLine(PrintTests(new Input([4,2,1,1,2], 1), [true,false,false,false,false]));
Console.WriteLine(PrintTests(new Input([12,1,12], 10), [true,false,true]));

record Input(int[] candies, int extraCandies);